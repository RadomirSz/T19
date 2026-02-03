<script setup lang="ts">
import { onMounted, ref } from 'vue';
import { auth, db } from '@/firebaseConfig';
import { collection, addDoc, query, where, getDocs } from 'firebase/firestore';

const artistF = ref('');
const songNameF = ref('');
const infoF = ref('');
const isSubmitting = ref(false);
// const errorMessage = ref('');
// const successMessage = ref('');

const submitSong = async () => {
  try {
    isSubmitting.value = true;
    // errorMessage.value = '';
    
    const artist = artistF.value.trim();
    const songName = songNameF.value.trim();
    const info = infoF.value.trim();
    
    // if (!artist || !songName) {
    //   errorMessage.value = 'Artist and Song Name are required';
    //   return;
    // }
    
    const suggestionData = {
      artist,
      songName,
      info,
      createdAt: new Date(),
      createdBy: auth.currentUser!.email,
      createdById: auth.currentUser!.uid
    };
    
    await addDoc(collection(db, "suggestions"), suggestionData);

    //console.log('Song added to Firebase:', suggestionData);
    //successMessage.value = 'Song suggestion submitted successfully!';
    
    artistF.value = '';
    songNameF.value = '';
    infoF.value = '';
  } catch (error) {
    console.error('Error adding song to Firebase:', error);
    //errorMessage.value = 'Failed to submit song. Please try again.';
  } finally {
    isSubmitting.value = false;
    didUserRecentlySubmit();
  }
};

const recentSuggestion = ref(false);

const didUserRecentlySubmit = async () =>{
  const userSuggestionsQuery = query(
    collection(db, 'suggestions'),
    where('createdById', '==', auth.currentUser!.uid)
  );
  const userSuggestions = await getDocs(userSuggestionsQuery);
  const fifteenMinutesAgo = new Date(Date.now() - 15 * 60 * 1000);
  
  recentSuggestion.value = userSuggestions.docs.some(doc => {
    const suggestion = doc.data();
    const createdAt = suggestion.createdAt?.toDate ? suggestion.createdAt.toDate() : new Date(suggestion.createdAt);
    return createdAt > fifteenMinutesAgo;
  });

  // if (recentSuggestion) {
  //   console.log('User has already submitted a suggestion within the last 15 minutes');
  // }
};
onMounted(() => {
  didUserRecentlySubmit();
}); 
</script>

<template>
  <form class="form" @submit.prevent="submitSong">
    <h2>Add your suggestion</h2>
    
    <!-- <div v-if="errorMessage" class="error-message">{{ errorMessage }}</div>
    <div v-if="successMessage" class="success-message">{{ successMessage }}</div> -->
    
    <label for="artistF">Artist</label>
    <input type="text" id="artistF" placeholder="Artist" v-model="artistF" maxlength="50" required/>

    <label for="songNameF">Song Name</label>
    <input type="text" id="songNameF" placeholder="Song Name" v-model="songNameF" maxlength="50" required/>

    <label for="infoF">Additional Information</label>
    <textarea id="infoF" placeholder="Additional info (optional)" v-model="infoF" rows="3" maxlength="100"></textarea>

    <button v-if="!recentSuggestion" type="submit" :disabled="isSubmitting">
      {{ isSubmitting ? 'Submitting...' : 'Submit' }}
    </button>
    <p v-else>You can only add one suggesion every 15 minutes.</p>
  </form>
</template>

<style scoped>
.form {
  background: linear-gradient(160deg, #0f0f0f, #1a1a1a);
  width: 20vw;
  max-width: 700px;
  margin: 60px auto;
  padding: 40px 30px;
  border-radius: 12px;
  box-shadow: 0 8px 25px rgba(0, 139, 139, 0.2);
  border: 1px solid #007070;
  color: #e0f7fa;
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
  display: flex;
  flex-direction: column;
  gap: 16px;
}

h2 {
  color: #00bcbc;
  text-align: center;
  margin-bottom: 24px;
  font-size: 26px;
  font-weight: 600;
}

label {
  font-weight: 500;
  font-size: 15px;
  margin-bottom: 4px;
  color: #c2f2f2;
}

input,
textarea {
  background-color: #1c1c1c;
  border: 1px solid #00bcbc;
  color: #e0f7fa;
  padding: 12px 14px;
  border-radius: 6px;
  width: 90%;
  font-size: 15px;
  transition: border-color 0.3s, box-shadow 0.3s;
}

input:focus,
textarea:focus {
  border-color: #00e0e0;
  box-shadow: 0 0 8px rgba(0, 224, 224, 0.4);
  outline: none;
}

button {
  background: linear-gradient(90deg, #008b8b, #005f5f);
  color: white;
  border: none;
  padding: 14px;
  font-size: 16px;
  font-weight: bold;
  border-radius: 6px;
  cursor: pointer;
  transition: background 0.3s, transform 0.2s ease-in-out;
}

button:hover {
  background: linear-gradient(90deg, #00aaaa, #007777);
  transform: translateY(-2px);
}

button:disabled {
  background-color: #446666;
  cursor: not-allowed;
  opacity: 0.6;
}

p {
  text-align: center;
  margin-top: 12px;
  color: #bbbbbb;
  font-style: italic;
  font-size: 14px;
}

@media (max-width: 600px) {
  .form {
    padding: 25px 20px;
  }

  h2 {
    font-size: 22px;
  }

  input,
  textarea,
  button {
    font-size: 14px;
  }
}
</style>
