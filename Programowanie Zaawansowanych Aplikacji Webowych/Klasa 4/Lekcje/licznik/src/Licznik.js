import { Component, React } from "react";
import { render } from "@testing-library/react";

class Licznik extends Component{

    constructor(props){
        super(props);
        this.state={
            licznik: 0
        }
        this.zwieksz = this.zwieksz.bind(this);
        this.zmniejsz = this.zmniejsz.bind(this);
        this.zeruj = this.zeruj.bind(this);
    }
    zwieksz = () =>{
        this.setState((prevState)=>({
            licznik: prevState.licznik+1})
        );
    }
    
    zmniejsz= () =>{
        this.setState((prevState)=>({
            licznik: prevState.licznik-1})
        );
    }

    zeruj= () =>{
        this.setState({
            licznik: 0
        })
    }

    ustawWartosc = value =>{
        this.setState({
            licznik: value
        })
    }

    render(){
        return(
            <div>
                <br/>
                Stan licznika: {this.state.licznik}<br/><br/>
                <button onClick={this.zwieksz}>Zwieksz o 1</button><br/><br/>
                <button onClick={this.zmniejsz}>Zmniejsz o 1</button><br/><br/>
                <button onClick={this.zeruj}>zeruj</button><br/><br/>
                <button onClick={()=>this.ustawWartosc(parseInt(prompt("Podaj wartość")))}>ustaw wartosc</button><br/><br/>
            </div>
        )
    }
}

export default Licznik;