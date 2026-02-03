<script setup>
import { ref } from 'vue';
import X from './images/x.png';
import V from './images/v.png';

const props = defineProps({
    Artist: {
        type: String,
        default: 'Unknown',
    },
    SongName: {
        type: String,
        required: true,
    },
    Info: {
        type: String,
        default: "No additional information",
    }
});

const emit = defineEmits(['remove-song', 'add-song']);
const songToRemove = ref({ Artist: props.Artist, SongName: props.SongName, Info: props.Info });
const songToAdd = ref({ artist: props.Artist, song: props.SongName});
const removeSong = () => {
    emit('remove-song', songToRemove.value);
};

const addSong = () => {
    emit('add-song', songToAdd.value);
    removeSong();
};
</script>

<template>
    <div class="item">
        <p>{{ props.Artist }} - {{ props.SongName }} - {{ props.Info }}</p>
        <img :src="X" alt="X" @click="removeSong" />
        <img :src="V" alt="V" @click="addSong" />
    </div>
</template>

<style scoped>
</style>