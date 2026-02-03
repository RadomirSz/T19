<script setup lang="ts">
import { ref, onMounted } from 'vue';
import router from '@/router';
import { auth, db } from '@/firebaseConfig';
import { signOut } from 'firebase/auth';
import { doc, getDoc } from 'firebase/firestore';
import SuggestionsList from '@/components/suggestionsList.vue';


const signOutHandler = () =>{
  signOut(auth).then(() => {
    router.push('/');
  }).catch((error) => {
    console.error(error);
  });
};

const isCurrentUserAdmin = ref(false);

onMounted(async () => {
  const userDoc = await getDoc(doc(db, 'admins', auth.currentUser!.uid));
  isCurrentUserAdmin.value = userDoc.exists();
});
</script>

<template>

  <div v-if="isCurrentUserAdmin">
    <header class="top-bar">
      <div class="left">
        <RouterLink to="/home">Home</RouterLink>
        <button @click="signOutHandler">Sign Out</button>
      </div>
    </header>
    
    <SuggestionsList />
  </div>
  <p v-else>
    You are not an admin. Please contact the administrator for access.
  </p>
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

.left {
  display: flex;
  gap: 15px;
  align-items: center;
}

.left a {
  color: #00bcbc;
  text-decoration: none;
  font-weight: bold;
  padding: 8px 14px;
  border: 1px solid #00bcbc;
  border-radius: 6px;
  transition: background-color 0.3s ease, color 0.3s ease;
}

.left a:hover {
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
</style>