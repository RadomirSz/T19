import { Component } from 'react';
import Oferta from './oferta';

class WyswietlOferty extends Component{
    constructor(props){
        super(props);
        this.state = {
            shoes: props.shoes
        }
    }
    render(){
        return(
            <div>
                { this.state.shoes.map(shoe => (
                    <Oferta shoe={shoe}/>
                ))} 
            </div>
        );
    }

}
export default WyswietlOferty;