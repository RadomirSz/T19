import React, {useEffect, useState} from "react";

function App() {
    const [odp, setOdp] = useState({message: null,name: null, email: null});

    useEffect(()=>{
        const osoba = {name: "Jan Kowalski", email:"jan@przyklad.com"}
        fetch("https://localhost:3100/api/data",{
            method: 'POST',
            headers: {
                'Content-type':'application/json'
            },
            body: JSON.stringify(osoba)
        })
        .then(res => res.json())
        .then((json_data) => setOdp({
            message: json_data.zwrot.message,
            name: json_data.zwrot.name,
            email:json_data.zwrot.email
        }
        ))
        .catch(e => console.error(e))
        },[])

    return(
        <h1> odpowiedz od serwera: {odp.message} {odp.name} {odp.email}</h1> 
    )
}
export default App;