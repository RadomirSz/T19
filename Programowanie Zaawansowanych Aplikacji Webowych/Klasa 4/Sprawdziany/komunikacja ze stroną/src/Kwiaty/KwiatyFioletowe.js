import { Component } from "react";

class KwiatyFioletowe extends Component {
    render() {
        return (
        <div>
            <h2 className="polecamy">Polecamy: kwiaty fioletowe</h2>
            <img src="./kwiat.png" alt="kwiat"  width="100" height="100"/>
            <h2 className="ilosc-tekst">Ilość rano 15</h2>
            <h2 className="ilosc-tekst">Ilość wieczorem 6</h2>
        </div>
        );
    }
}

export default KwiatyFioletowe;
