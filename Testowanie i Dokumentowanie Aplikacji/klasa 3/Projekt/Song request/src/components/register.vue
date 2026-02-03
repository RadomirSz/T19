<script setup lang="ts">
import { ref } from 'vue';
import { useRouter } from 'vue-router';
import { auth } from '@/firebaseConfig';
import { createUserWithEmailAndPassword } from 'firebase/auth';

const email = ref('');
const password = ref('');
const password2 = ref('');
const router = useRouter();

const register = async () =>{

if (password.value !== password2.value) 
{
    alert("Passwords do not match!");
    return;
}
await createUserWithEmailAndPassword(auth, email.value, password.value)
    .then((/*data*/) => {
        router.push('/home');
        //console.log("registered", data.user);
    }).catch((error) => {
    if (error.code === 'auth/invalid-email') {
        console.error('Wrong email!');
    } else if (error.code === 'auth/weak-password') {
        console.error('Weak password!');
    } else {
        console.error('Error during register:', error.code, error.message);
    }
    });
};
</script>

<template>
    <div class="register-container">
        <div class="register-card">
            <h1>Register</h1>
            <form @submit.prevent="register">
                <div class="form-group">
                    <label for="email">Email</label>
                    <input type="text" id="email" v-model="email" required placeholder="Enter your email"/>
                </div>
                <div class="form-group">
                    <label for="password">Password</label>
                    <input type="password" id="password" v-model="password" required placeholder="Enter your password"/>
                </div>
                <div class="form-group">
                    <label for="password2">Password</label>
                    <input type="password" id="password2" v-model="password2" required placeholder="Confirm password"/>
                </div>
                
                <button type="submit" class="register-btn">
                    Register
                </button>
            </form>
        </div>
    </div>
</template>

<style scoped>
.register-container {
  display: flex;
  justify-content: center;
  align-items: center;
  min-height: 100vh;
  background: linear-gradient(160deg, #0e0e0e, #1a1a1a);
  font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
  padding: 20px;
}

.register-card {
  background-color: #181818;
  border: 1px solid #007070;
  border-radius: 12px;
  padding: 40px 30px;
  box-shadow: 0 8px 25px rgba(0, 139, 139, 0.25);
  width: 100%;
  max-width: 450px;
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
  margin-bottom: 20px;
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
  padding: 12px 14px;
  border: 1px solid #00aaaa;
  background-color: #202020;
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

.register-btn {
  background: linear-gradient(90deg, #008b8b, #006060);
  color: white;
  border: none;
  padding: 14px;
  width: 100%;
  font-size: 16px;
  font-weight: bold;
  border-radius: 6px;
  cursor: pointer;
  transition: background 0.3s, transform 0.2s ease-in-out;
  margin-top: 10px;
}

.register-btn:hover {
  background: linear-gradient(90deg, #00aaaa, #007777);
  transform: translateY(-2px);
}

@media (max-width: 480px) {
  .register-card {
    padding: 25px 20px;
  }

  h1 {
    font-size: 24px;
  }

  input,
  .register-btn {
    font-size: 14px;
  }
}
</style>
