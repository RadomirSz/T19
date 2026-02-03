<script setup lang="ts">
import { ref, onMounted } from 'vue';
import AddSuggestion from '@/components/addSuggestion.vue';
import SongList from '@/components/songList.vue';
import router from '@/router';
import { auth, db } from '@/firebaseConfig';
import { signOut } from 'firebase/auth';
import { doc, getDoc } from 'firebase/firestore';

const showAddSuggestion = ref(false);
const toggleAddSuggestion = () => {
  showAddSuggestion.value = !showAddSuggestion.value;
};

const signOutHandler = () => {
    signOut(auth).then(() => {
        router.push('/');
    }).catch((error) => {
        console.error('Error signing out:', error);
    });
};

const isCurrentUserAdmin = ref(false);

onMounted(async () => {
  const userDoc = await getDoc(doc(db, 'admins', auth.currentUser!.uid));
  isCurrentUserAdmin.value = userDoc.exists();
});
</script>

<template>
  <header class="top-bar">
    <div class="left">
      <button @click="signOutHandler">Sign Out</button>
    </div>
    <div class="right" v-if="isCurrentUserAdmin">
      <RouterLink to="/admin">Admin</RouterLink>
    </div>
  </header>

  <main>
    <div class="content-container">
      <div class="song-list-container">
        <SongList />
      </div>
      <div class="add-suggestion-container">
        <h3 @click="toggleAddSuggestion" class="addSuggestionButton">
          Add your suggestion
        </h3>
        <AddSuggestion v-if="showAddSuggestion" />
      </div>
    </div>
  </main>
</template>

<style scoped>
.top-bar {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 15px 30px;
  background-color: #121212;
  border-bottom: 1px solid #00bcbc;
  font-family: 'Segoe UI', sans-serif;
}

.left,
.right {
  display: flex;
  gap: 15px;
  align-items: center;
}

.left a,
.right a {
  color: #00bcbc;
  text-decoration: none;
  font-weight: bold;
  padding: 8px 14px;
  border: 1px solid #00bcbc;
  border-radius: 6px;
  transition: background-color 0.3s ease, color 0.3s ease;
}

.left a:hover,
.right a:hover {
  background-color: #00bcbc;
  color: #121212;
}

.left button {
  background-color: #ff6666;
  border: none;
  padding: 8px 14px;
  border-radius: 6px;
  color: white;
  font-size: 14px;
  cursor: pointer;
  transition: background-color 0.3s ease;
}

.left button:hover {
  background-color: #e65c5c;
}

main {
  display: flex;
  justify-content: center;
  padding: 20px;
  font-family: 'Segoe UI', sans-serif;
}

.content-container {
  display: flex;
  justify-content: center;
  align-items: flex-start;
  width: 100%;
  max-width: 1200px; /* Limit max width to keep the content centered */
}

.song-list-container {
  flex: 1;
  display: flex;
  justify-content: center;
}

.add-suggestion-container {
  display: flex;
  flex-direction: column;
  align-items: flex-start;
  margin-left: 30px;
  width: 300px;
}

.addSuggestionButton {
  margin: 30px 0 10px 0;
  background-color: #008b8b;
  padding: 12px 24px;
  border-radius: 8px;
  color: white;
  font-size: 18px;
  cursor: pointer;
  transition: background 0.3s ease;
  text-align: center;
}

.addSuggestionButton:hover {
  background-color: #00aaaa;
}

@media (max-width: 768px) {
  .top-bar {
    flex-direction: column;
    align-items: stretch;
  }

  .left,
  .right {
    justify-content: center;
    margin-bottom: 10px;
  }

  .addSuggestionButton {
    font-size: 16px;
    padding: 10px 18px;
  }

  .left button {
    font-size: 14px;
  }

  .content-container {
    flex-direction: column;
    align-items: center;
  }

  .add-suggestion-container {
    margin-left: 0;
    margin-top: 20px;
    width: 100%;
  }
}
</style>
