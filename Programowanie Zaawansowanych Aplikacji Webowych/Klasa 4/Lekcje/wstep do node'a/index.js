const express = require('express');
const cors = require('cors');

const app = express();
const PORT = 3100;
app.use(cors());
app.use(express.json());

app.post('/api/data',function(req,res) {
    const receivedData = req.body;
    console.log('Received JSON data:', receivedData);
    res.status(200).json(
        {message: 'Data received succesfully!', zwrot: receivedData}
    );
});



app.get('/api/data',(req,res)=>{
    res.json({message:"pdw"});
});

app.listen(PORT, ()=>{
    console.log(`server is running on localhost:${PORT}`);
});