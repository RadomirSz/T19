<script setup>
import { ref } from 'vue';
import upvoteclicked from './images/up-vote-clicked.png'
import upvote from './images/up-vote-unclicked.png'
import downvoteclicked from './images/down-vote-clicked.png'
import downvote from './images/down-vote-unclicked.png'

const clicked = ref('none');
const vote = (a) => {
    if (a === 'up') {
        if (clicked.value === 'up') {
            clicked.value = 'none';
            emit('updateVotes', -1); // Odejmij głos
        } else if (clicked.value === 'none') {
            clicked.value = 'up';
            emit('updateVotes', 1); // Dodaj głos
        } else if (clicked.value === 'down') {
            clicked.value = 'up';
            emit('updateVotes', 2); // Zmień z downvote na upvote
        } else {
            console.log('error upvote logic');
        }
    } else if (a === 'down') {
        if (clicked.value === 'down') {
            clicked.value = 'none';
            emit('updateVotes', 1); // Przywróć głos
        } else if (clicked.value === 'none') {
            clicked.value = 'down';
            emit('updateVotes', -1); // Odejmij głos
        } else if (clicked.value === 'up') {
            clicked.value = 'down';
            emit('updateVotes', -2); // Zmień z upvote na downvote
        } else {
            console.log('error downvote logic');
        }
    } else {
        console.log('error - vote function');
    }
};

defineProps({
    Artist: {
        type: String,
        default: 'Unknown',
    },
    SongName: {
        type: String,
        required: true,
    },
    Votes:{
        type: Number,
        default: 0,
    }  
});

const emit = defineEmits(['updateVotes']);
</script>

<template>
<div class="item">
    <div class="left">

        <img v-if="clicked === 'up'" :src=upvoteclicked alt="upvote" @click="vote('up')" />
        <img v-else :src=upvote alt="upvote" @click="vote('up')" />

        <p>{{ Votes }}</p>

        <img v-if="clicked === 'down'" :src=downvoteclicked alt="upvote" @click="vote('down')" />
        <img v-else :src=downvote alt="downvote" @click="vote('down')" />
        
    </div>

    <div class="right">
        <p>{{ Artist }} - {{ SongName }}</p>
    </div>
</div>
</template>

<style scoped>
.item{
    display: flex;
    padding: 10px;
    border: 1px solid #000000;
    font-size: xx-large;
    width: 100%;
}
.left{
    padding-right: 2%;
    text-align: center;
    border-right: solid 1px #000000;
}
img{
    width: 40px;
    height: 40px;
}
img:hover{
    cursor: pointer;
}

.right{
    padding-left: 2%;
    padding-top: 5%;
}

</style>