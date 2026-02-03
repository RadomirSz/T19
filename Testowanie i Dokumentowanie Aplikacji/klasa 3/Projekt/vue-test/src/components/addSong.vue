<script setup>
import { ref } from 'vue';

const list = ref([]);
const artistF = ref('');
const songNameF = ref('');
const infoF = ref('');

// Emit event to parent
const emit = defineEmits(['add-song','close-form']);
const submitSong = () => {
  const artist = artistF.value.trim();
  const songName = songNameF.value.trim();
  const info = infoF.value.trim();

  list.value.push({ Artist: artist, SongName: songName, Info: info });
  
  console.log('Song added:', { Artist: artist, SongName: songName, Info: info });
  
  // Emit the song data to the parent component
  const newSong = { artist, song: songName, info: infoF.value.trim() };
  emit('add-song', newSong);
  emit('close-form');

  // Clear the form fields
  artistF.value = '';
  songNameF.value = '';
  infoF.value = '';
};
</script>

<template>
  <form class="form" @submit.prevent="submitSong">
    <h2>Add your suggestion</h2>
    <label for="artistF">Artist</label>
    <input
      type="text"
      id="artistF"
      placeholder="Artist"
      v-model="artistF"
      required
    />

    <label for="songNameF">Song Name</label>
    <input
      type="text"
      id="songNameF"
      placeholder="Song Name"
      v-model="songNameF"
      maxlength="50"
      required
    />

    <label for="infoF">Additional Information</label>
    <textarea
      id="infoF"
      placeholder="Additional info (optional)"
      v-model="infoF"
      rows="3"
      maxlength="100"
    ></textarea>

    <button type="submit">Submit</button>
  </form>
</template>


<style scoped>
form{
    border: grey solid 1px;
    border-radius: 3%;
    padding: 10px;
}
.form-container {
  width: 100%;
  max-width: 400px;
  background: #fff;
  padding: 20px;
  border-radius: 8px;
  box-shadow: 0 4px 6px rgba(0, 0, 0, 0.1);
}

.form h2 {
  margin-bottom: 20px;
  font-size: 24px;
  color: #333;
}

.form label {
  display: block;
  margin-bottom: 8px;
  font-weight: bold;
  color: #555;
}

.form input, .form textarea, .form button {
  width: 100%;
  margin-bottom: 15px;
  padding: 10px;
  border: 1px solid #ccc;
  border-radius: 4px;
  font-size: 16px;
  color: #000000;
  box-sizing: border-box;
}

.form input:focus, .form textarea:focus {
  outline: none;
  border-color: #aaaaaa;
  box-shadow: 0 0 4px rgba(107, 107, 107, 0.4);
}

.form button {
  background: #aaaaaa;
  color: black;
  border: none;
  cursor: pointer;
  transition: 0.2s ease;
}

.form button:hover {
  background: #777777;
}
</style>
