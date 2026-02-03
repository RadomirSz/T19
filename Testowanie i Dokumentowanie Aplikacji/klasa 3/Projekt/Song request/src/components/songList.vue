 <script setup lang="ts">
import { ref, onMounted } from 'vue';
import { auth, db } from "../firebaseConfig";
import { collection, doc, updateDoc, getDocs } from 'firebase/firestore';

interface Song {
  id: string;
  artist: string;
  songName: string;
  votes: number;
  voters: {
    [userId: string]: number; // userId mapped to vote value (1 for upvote, -1 for downvote)
  };
  userVote: number; // user's vote for the song (1 for upvote, -1 for downvote, 0 for no vote)
  //[key: string]: any; // for any other properties from Firestore
}
const songs = ref<Song[]>([]);

const fetchSongs = async () => {
    try {
    const querySnapshot = await getDocs(collection(db, 'songs'));
    songs.value = querySnapshot.docs.map(doc => ({
      id: doc.id,
      ...doc.data(),
      artist: doc.data().artist || 'Unknown',
      songName: doc.data().songName || 'Unknown',
      votes: doc.data().votes || 0,
      voters: doc.data().voters || {},
      userVote: doc.data().voters[auth.currentUser!.uid] || 0 
    } as Song));
    } catch (error) {
        console.error('Error fetching songs:', error);
    }
};



const updateVotes = async (songId: string, newVotes: number, userId: string | undefined, userVote: number) => {
  try {
    const songRef = doc(db, 'songs', songId);
    await updateDoc(songRef, {
      votes: newVotes,
      [`voters.${userId}`]: userVote  // Store the user's vote (1 for upvote, 0 for no vote, -1 for downvote)
    });
  } catch (error) {
    console.error('Error updating votes:', error);
  }
};


const updateVotesHandler = async (songId: string, voteChange: number) => {
  
  let userId : string | undefined = auth.currentUser!.uid;
  const song : Song = songs.value.find(song => song.id === songId)!;
  let newVotes : number = song.votes; 
  
  switch (voteChange) {
    case 1: 
      if(song.userVote === -1) newVotes += 2;
      else newVotes += 1;
      break;
    case -1:
      if(song.userVote === 1) newVotes -= 2;
      else newVotes -= 1;
      break;
    default:
      newVotes -= song.userVote;
      break;
    }
  
  await updateVotes(songId, newVotes, userId, voteChange);
  
  // ensure UI is in sync
  await fetchSongs();
};

onMounted(() => {
    fetchSongs();
});
</script>

<template>
    <main>
        <ul v-if="songs.length > 0">
            <li v-for="item in songs" :key="item.id">
                <p>{{ item.artist }} - {{ item.songName }}</p>

                <img v-if="item.userVote === 0 || item.userVote === -1" src="../assets/blackUp.png" @click="updateVotesHandler(item.id, 1)" alt="up vote image" />
                <img v-else @click="updateVotesHandler(item.id, 0)" src="../assets/greenUp.png" alt="clicked up vote image" />

                <p>{{ item.votes }}</p>

                <img v-if="item.userVote === 0 || item.userVote === 1" src="../assets/blackDown.png" @click="updateVotesHandler(item.id, -1)" alt="down vote image" />
                <img v-else @click="updateVotesHandler(item.id, 0)" src="../assets/redDown.png" alt="clicked down vote image" />
            </li>
        </ul>
        <p v-else>No songs added yet</p>
    </main>
</template>

<style scoped>
main {
  max-width: 700px;
  margin: 50px auto;
  padding: 20px;
  color: #e0f7fa;
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
}

ul {
  list-style: none;
  padding: 0;
  display: flex;
  flex-direction: column;
  gap: 16px;
}

li {
  background: linear-gradient(50deg, #202020, #525252);
  border: 1px solid #007070;
  border-radius: 12px;
  padding: 20px;
  display: grid;
  grid-template-columns: 1fr auto auto auto;
  align-items: center;
  gap: 16px;
  box-shadow: 0 8px 20px rgba(0, 139, 139, 0.15);
  transition: transform 0.2s ease-in-out;
}

li:hover {
  transform: translateY(-3px);
}

li p {
  margin: 0;
  font-size: 16px;
  font-weight: 500;
  color: #c2f2f2;
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

@media (max-width: 768px) {
  li {
    grid-template-columns: 1fr auto auto auto;
    padding: 16px;
  }

  img {
    width: 32px;
    height: 32px;
  }

  li p {
    font-size: 14px;
  }
}

p {
  text-align: center;
  font-size: 16px;
  margin-top: 20px;
  color: #bbbbbb;
}
</style>
