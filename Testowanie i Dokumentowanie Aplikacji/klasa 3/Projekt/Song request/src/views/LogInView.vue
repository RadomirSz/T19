<script setup lang="ts">
import { ref } from 'vue';
import router from '@/router';
import { auth } from '@/firebaseConfig';
import { GoogleAuthProvider, signInWithPopup } from 'firebase/auth';
import signIn from '@/components/signIn.vue';
import register from '@/components/register.vue';

const option = ref('');
const setOption = (selectedOption: string) => {
    option.value = option.value == selectedOption ? '' : selectedOption;
};

const singInWithGoogle = () =>{
    const provider = new GoogleAuthProvider();
    signInWithPopup( auth, provider )
        .then((/*result*/) => {
            router.push('/home');
            //console.log("User signed in: ", result.user);
        }).catch((error) => {
            if (error.code === 'auth/popup-closed-by-user') {
                console.error('The popup was closed before completing the sign-in.');
            } else if (error.code === 'auth/cancelled-popup-request') {
                console.error('Another popup request was made before this one was completed.');
            } else {
                console.error('Error during sign-in:', error.code, error.message);
            }
        });
};
</script>

<template>
    
    <div class="options">
        <button @click="setOption('signin')"> Zaloguj się</button>
        <p>Don't have an account? <button @click="setOption('register')"> Zarejestrtuj się</button></p>
        <button @click="singInWithGoogle">Zaloguj się przez Google</button>
    </div>
    <signIn v-if="option == 'signin'"/>
    <register v-if="option == 'register'"/>
</template>

<style scoped>

</style>