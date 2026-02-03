<script setup lang="ts">
import { ref, onMounted } from 'vue';
import { db } from '../firebaseConfig'; 
import { 
    collection, 
    getDocs, 
    doc, 
    deleteDoc, 
    addDoc } from 'firebase/firestore';
import X from '../assets/x.png';
import V from '../assets/v.png';

interface Suggestion {
  id: string;
  artist: string;
  songName: string;
  info: string;
  //[key: string]: any;
}

const Suggestions = ref<Suggestion[]>([]);

const fetchSuggestions = async () => {
    try {
        const querySnapshot = await getDocs(collection(db, 'suggestions'));
        Suggestions.value = querySnapshot.docs.map(doc => {
            const data = doc.data();
            return { 
                id: doc.id, 
                artist: data.artist || 'Unknown',
                songName: data.songName || 'Unknown',
                info: data.info || 'No additional information',
                //...data 
            } as Suggestion;
        });
    } catch (error) {
        console.error('Error fetching suggestions from Firebase:', error);
    }
};



const removeSong = async (id: string) => {
    try {
        await deleteDoc(doc(db, 'suggestions', id));
        fetchSuggestions();
        //Suggestions.value = Suggestions.value.filter(suggestion => suggestion.id !== id);
        // console.log('Suggestion removed successfully');
    } catch (error) {
        console.error('Error removing suggestion:', error);
    }
};


const addSong = async (suggestion: Suggestion) => {
    try {
        await addDoc(collection(db, 'songs'), {
            artist: suggestion.artist,
            songName: suggestion.songName,
            votes: 0,
            voters: {},
            addedAt: new Date()
        });
        await removeSong(suggestion.id);
        // console.log('Song added to database successfully');
    } catch (error) {
        console.error('Error adding song to database:', error);
    }
};

onMounted(() => {
    fetchSuggestions();
});
</script>

<template>
<p v-if="Suggestions.length == 0">No suggestions</p>

<ul v-else>
    <li v-for="item in Suggestions" :key="item.id">
        <div class="item">
            <p>{{ item.artist }} - {{ item.songName }} - {{ item.info }}</p>
            <img :src="X" alt="Decline song" @click="removeSong(item.id)" />
            <img :src="V" alt="Approve song" @click="addSong(item)" />
        </div>
    </li>
</ul>
</template>

<style scoped>
ul {
  list-style-type: none;
  padding: 0;
  max-width: 700px;
  margin: 40px auto;
  display: flex;
  flex-direction: column;
  gap: 20px;
  font-family: 'Segoe UI', sans-serif;
  color: #e0f7fa;
}

li {
  background: linear-gradient(135deg, #141414, #1e1e1e);
  border: 1px solid #008b8b;
  border-radius: 12px;
  box-shadow: 0 8px 20px rgba(0, 139, 139, 0.15);
  padding: 20px;
  transition: transform 0.2s ease-in-out;
}

li:hover {
  transform: translateY(-3px);
}

.item {
  display: grid;
  grid-template-columns: 1fr auto auto;
  align-items: center;
  gap: 16px;
}

.item p {
  margin: 0;
  font-size: 16px;
  color: #c2f2f2;
}

.item p + p {
  font-size: 14px;
  color: #a5d8d8;
}

img {
  width: 36px;
  height: 36px;
  cursor: pointer;
  transition: transform 0.2s;
}

img:hover {
  transform: scale(1.1);
}

p {
  text-align: center;
  font-size: 16px;
  margin-top: 30px;
  color: #bbbbbb;
}

@media (max-width: 768px) {
  .item {
    grid-template-columns: 1fr auto auto;
  }

  img {
    width: 30px;
    height: 30px;
  }

  .item p {
    font-size: 14px;
  }

  .item p + p {
    font-size: 13px;
  }
}
</style>
