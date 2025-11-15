import { Component } from 'react';
import Oferta from './oferta';

class WyswietlOferty extends Component{
    render(){
        const { shoes, onSprzedaz, onPrzyjecie } = this.props;
        
        const letnieShoes = shoes.filter(shoe => shoe.season === 'letnie');
        const zimoweShoes = shoes.filter(shoe => shoe.season === 'zimowe');
        
        return(
            <div>
                {letnieShoes.length > 0 && (
                    <div>
                        <h2>Obuwie letnie</h2>
                        {letnieShoes.map(shoe => (
                            <Oferta shoe={shoe} key={shoe.id} onSprzedaz={onSprzedaz} onPrzyjecie={onPrzyjecie}/>
                        ))}
                    </div>
                )}
                
                {zimoweShoes.length > 0 && (
                    <div>
                        <h2>Obuwie zimowe</h2>
                        {zimoweShoes.map(shoe => (
                            <Oferta shoe={shoe} key={shoe.id} onSprzedaz={onSprzedaz} onPrzyjecie={onPrzyjecie}/>
                        ))}
                    </div>
                )}
            </div>
        );
    }

}
export default WyswietlOferty;