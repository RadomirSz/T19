import { Component } from "react";

class KwiatyNiebieskie extends Component {
    constructor(props) {
        super(props);
        this.state = {
            wartosc3: props.iloscWieczor,
            wartosc4: props.iloscRano
        };
        this.przyjmij = this.przyjmij.bind(this);
        this.usun = this.usun.bind(this);
    }
    przyjmij = () => {
        if (this.props.onToggleKwiaty) {
            this.props.onToggleKwiaty(true);
        }
    }
    usun = () => {
        if (this.props.onToggleKwiaty) {
            this.props.onToggleKwiaty(false);
        }
    }
    render() {
        return (
        <div>
            <h2 className="polecamy">Polecamy: kwiaty niebieskie</h2>
            <img src="./kwiat.png" alt="kwiat"  width="100" height="100"/>
            <h2 className="ilosc-tekst">Ilość rano {this.state.wartosc4}</h2>
            <h2 className="ilosc-tekst">Ilość wieczorem {this.state.wartosc3}</h2>
            <button onClick={this.przyjmij}>Przyjmij</button>
            <button onClick={this.usun}>Usuń</button>
        </div>
    );
    }
}

export default KwiatyNiebieskie;