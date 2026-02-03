<script setup>
import { ref, onMounted } from 'vue';
import { db } from './firebaseConfig';
import { collection, getDocs, addDoc, deleteDoc, doc } from 'firebase/firestore';
import Song from './components/song.vue';
import AddSong from './components/addSong.vue';
import AdminView from './components/adminView.vue';

// State to manage song list and visibility of AddSong
const songs = ref([]);

// Function to fetch songs from Firestore
const fetchSongs = async () => {
  const querySnapshot = await getDocs(collection(db, "songs"));
  querySnapshot.forEach((doc) => {
    songs.value.push({ id: doc.id, ...doc.data() });
  });
};

// Function to handle votes
const updateVotes = async (index, change) => {
  const song = songs.value[index];
  song.votes += change;
  await updateDoc(doc(db, "songs", song.id), { votes: song.votes });
};

const showAddSong = ref(false);
// Toggle AddSong form visibility
const toggleAddSong = () => {
  showAddSong.value = !showAddSong.value;
};

const user = ref('admin'); // to do - add login/logout logic with user state (admin - user - none)

const showAdminView = ref(false);
// Toggle AddSong form visibility
const toggleAdminView = () => {
  showAdminView.value = !showAdminView.value;
};

const suggestions = ref([]);
// Function to handle new song submissions
const addSongToSubmissions = async (newSong) => {
  const docRef = await addDoc(collection(db, "suggestions"), { ...newSong, votes: 0 });
  suggestions.value.push({ id: docRef.id, ...newSong });
};

// Function to remove a song from the list
const removeSong = async (song) => {
  await deleteDoc(doc(db, "suggestions", song.id));
  suggestions.value = suggestions.value.filter(
    (item) => item.id !== song.id
  );
};

// Function to add a song to the main list
const addSongToMain = async (newSong) => {
  const docRef = await addDoc(collection(db, "songs"), { ...newSong, votes: 0 });
  songs.value.push({ id: docRef.id, ...newSong });
  removeSong(newSong);
};

const tasks = ref([]);

onMounted(async () => {
  try {
    await fetchSongs();
  } catch (error) {
    console.log('Error fetching songs:', error);
  }
});
</script>

<template>
  <main>
    <section class="left">
      <p v-if="showAdminView && user == 'admin' && suggestions.length == 0">No suggestions</p>
      <ol v-else-if="showAdminView && user == 'admin' && suggestions.length > 0">
          <li v-for="item in suggestions" :key="item.song">
              <AdminView 
              :Artist="item.artist" 
              :SongName="item.song" 
              :Info="item.info" 
              @remove-song="removeSong" 
              @add-song="addSongToMain"/>
          </li>
      </ol>
    </section>
    <section class="middle">
      <ul>
        <li v-for="(item, index) in songs" :key="item.song">
          <Song
            :Artist="item.artist"
            :SongName="item.song"
            :Votes="item.votes"
            @updateVotes="change => updateVotes(index, change)"
          />
        </li>
      </ul>
    </section>
    
    <section class="right">
      <!-- <h3>
         Add login/logout logic here
        <p>Log in</p>
      </h3> -->
      <h3 @click="toggleAddSong" >
        Add your suggestion
      </h3>

     <AddSong v-if="showAddSong" @close-form="toggleAddSong" @add-song="addSongToSubmissions"/>

     <h3 v-if="user == 'admin'" @click="toggleAdminView">
        Admin view
     </h3>

    </section>
    
  </main>
</template>



<style scoped>
/* TODO */
main {
  display: flex;
  justify-content: center;
  grid-template-columns: 1fr auto;
  background-color: #f0f0f0;
  font-family:Arial, Helvetica, sans-serif;
}

ul {
  list-style-type: none;
  padding: 0;
  margin: 0;
}
li{
    margin: 10px;
    padding: 10px;
    border: 1px solid #000000;
    font-size: xx-large;
    background-color: #ffffff;
    display: flex;
    justify-content: center;
    align-items: center;
    border-radius: 10px;
    max-width: 45vw;
}

h3{
    text-align: center;
    font-size: 24px;
    color: #333;
    border: grey solid 1px;
    border-radius: 7px;
    padding: 10px;
    cursor: pointer;
}

.left {
  width: 20vw;
}

.middle {
  width: 40vw;
}

.right {
  width: 20vw;
}


</style>