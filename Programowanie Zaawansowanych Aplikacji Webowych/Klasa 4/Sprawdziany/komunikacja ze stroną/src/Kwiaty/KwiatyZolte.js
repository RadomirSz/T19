import { Component } from "react";

class KwiatyZolte extends Component {    
    render() {
        return (
        <div>
            <h2 className="polecamy">Polecamy: kwiaty żółte</h2>
            <img src="./kwiat.png" alt="kwiat"  width="100" height="100"/>
            <h2 className="ilosc-tekst">Ilość rano 27</h2>
            <h2 className="ilosc-tekst">Ilość wieczorem 8</h2>
            <button onClick={this.props.onUkryj}>Ukryj</button>
        </div>
        );
    }
}

export default KwiatyZolte;
