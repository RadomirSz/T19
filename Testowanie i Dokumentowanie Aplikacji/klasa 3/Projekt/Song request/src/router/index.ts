import { onAuthStateChanged } from 'firebase/auth'
import { auth } from '@/firebaseConfig';
import { createRouter, createWebHistory } from 'vue-router'
const HomeView = () => import('@/views/HomeView.vue')
const AdminView = () => import('@/views/AdminView.vue')
const LogInView = () => import('@/views/LogInView.vue')

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'login',
      component: LogInView,
      meta:{
        title: 'Log In',
        requiresAuth: false,
      }
    },{
      path: '/home',
      name: 'home',
      component: HomeView,
      meta:{
        title: 'Home',
        requiresAuth: true,
      }
    },{
      path: '/admin',
      name: 'admin',
      component: AdminView,
      meta:{
        title: 'Admin',
        requiresAuth: true,
      }
    }
  ],
});

const getCurrentUser = () => {
  return new Promise((resolve, reject) => {
    const removeListener = onAuthStateChanged(
      auth, 
      (user) => {
      removeListener();
      resolve(user);
      }, 
      reject
    );
  });
};

router.beforeEach(async (to, from, next) => {
  if(to.matched.some((record) => record.meta.requiresAuth)){
    if(await getCurrentUser()){
      next();
    }
    else{
      alert('You must be logged in to view this page');
      next("/");
    }
  }
  else{
    next();
  }
});

export default router