
import { useState } from "react";

function EmailInput() {
    const [errorMessage, setErrorMessage] = useState('');
    function evaluateEmail (event) {
        const enteredEmail = event.target.value;
        alert('funkcyjka');
        if (enteredEmail.trim() || !enteredEmail.includes("@")) {
            setErrorMessage('Bledny adres email.');
        }
        else {
            setErrorMessage("Jest dobrze");
        };
    }
    return (
        <div>
            <h5>Wejsciowka</h5>
            <input placeholder="user@skrzynka" type="email" onblur={evaluateEmail} />
            <p>(errorMessage)</p>
        </div>
        );
};

export default EmailInput;