<script setup lang="ts">
import { ref } from 'vue';
import { useRouter } from 'vue-router';
import { auth } from '@/firebaseConfig';
import { signInWithEmailAndPassword } from 'firebase/auth';

const email = ref('');
const password = ref('');
const error = ref('');
const router = useRouter();


const login = async () =>{
  await signInWithEmailAndPassword(auth, email.value, password.value)
    .then((/*data*/) => {
      router.push('/home');
      // console.log("logged in!", data.user); 
    }).catch((error) => {
      if (error.code === 'auth/invalid-email') {
          console.error('Wrong email!');
      } else if (error.code === 'auth/invalid-credential') {
          console.error('Wrong password!');
      } else {
          console.error('Error during sign-in:', error.code, error.message);
      }
    });
};
</script>

<template>
  <div class="login-container">
    <div class="login-card">
      <h1>Login</h1>
      <div v-if="error" class="error-message">{{ error }}</div>

      <form @submit.prevent="login">
        <div class="form-group">
          <label for="email">Email</label>
          <input type="text" id="email" v-model="email" required placeholder="Enter your email"/>
        </div>
        
        <div class="form-group">
          <label for="password">Password</label>
          <input type="password" id="password" v-model="password" required placeholder="Enter your password"/>
        </div>
        
        <button type="submit" class="login-btn">
          Login
        </button>
      </form>
    </div>
  </div>
</template>

<style scoped>
.login-container {
  display: flex;
  justify-content: center;
  align-items: center;
  min-height: 100vh;
  background: linear-gradient(160deg, #0f0f0f, #1a1a1a);
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
  padding: 20px;
}

.login-card {
  background-color: #181818;
  border: 1px solid #008b8b;
  border-radius: 12px;
  padding: 40px 30px;
  box-shadow: 0 8px 25px rgba(0, 139, 139, 0.2);
  width: 100%;
  max-width: 420px;
  color: #e0f7fa;
  transition: all 0.3s ease;
}

h1 {
  font-size: 28px;
  text-align: center;
  margin-bottom: 25px;
  color: #00bcbc;
  font-weight: 600;
}

.form-group {
  margin-bottom: 18px;
}

label {
  display: block;
  margin-bottom: 8px;
  font-weight: 500;
  color: #c2f2f2;
  font-size: 15px;
}

input {
  width: 93%;
  padding: 12px 15px;
  border: 1px solid #00aaaa;
  background-color: #1f1f1f;
  color: #e0f7fa;
  border-radius: 6px;
  font-size: 15px;
  transition: border-color 0.3s, box-shadow 0.3s;
}

input:focus {
  border-color: #00e0e0;
  box-shadow: 0 0 8px rgba(0, 224, 224, 0.4);
  outline: none;
}

.login-btn {
  width: 100%;
  padding: 14px;
  background: linear-gradient(90deg, #008b8b, #005f5f);
  color: #ffffff;
  border: none;
  border-radius: 6px;
  font-size: 16px;
  font-weight: bold;
  cursor: pointer;
  transition: background 0.3s, transform 0.2s ease-in-out;
}

.login-btn:hover {
  background: linear-gradient(90deg, #00aaaa, #007777);
  transform: translateY(-2px);
}

.login-btn:disabled {
  background-color: #444;
  cursor: not-allowed;
  opacity: 0.6;
}

.error-message {
  background-color: #2f1a1a;
  border: 1px solid #ff4d4d;
  color: #ff9999;
  padding: 12px;
  border-radius: 6px;
  margin-bottom: 20px;
  font-size: 14px;
  text-align: center;
}

@media (max-width: 480px) {
  .login-card {
    padding: 25px 20px;
  }

  h1 {
    font-size: 24px;
  }

  input,
  .login-btn {
    font-size: 14px;
  }
}
</style>