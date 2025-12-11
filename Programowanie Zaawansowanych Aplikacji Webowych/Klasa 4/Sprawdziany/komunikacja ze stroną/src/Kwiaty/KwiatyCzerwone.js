import { Component } from "react";

class KwiatyCzerwone extends Component {
    constructor(props) {
        super(props);
        this.state = {
            wartosc1: props.iloscStartowa,
            wartosc2: props.iloscStartowa
        };
        this.sprzedaj = this.sprzedaj.bind(this);
        this.kup = this.kup.bind(this);
    }
    sprzedaj = () => {
        this.setState((prevState) => ({
            wartosc2: prevState.wartosc2 > 0 ? prevState.wartosc2 - 1 : 0
        }));
    }
    kup = (ilosc) => {
        const liczba = Number(ilosc);
        if (liczba > 0) {
            this.setState((prevState) => ({
                wartosc1: prevState.wartosc1 + liczba
            }));
        }
    }
    render() {
        return (
        <div>
            <h2 className="polecamy">Polecamy: kwiaty czerwone</h2>
            <img src="./kwiat.png" alt="kwiat"  width="100" height="100"/>
            <h2 className="ilosc-tekst">Ilość rano {this.state.wartosc1}</h2>
            <h2 className="ilosc-tekst">Ilość wieczorem {this.state.wartosc2}</h2>
            <button onClick={this.sprzedaj}>Sprzedaj</button>
            <button onClick={() => this.kup(prompt("Podaj ilość do kupienia:"))}>Kup</button>
        </div>
    );
    }
}

export default KwiatyCzerwone;