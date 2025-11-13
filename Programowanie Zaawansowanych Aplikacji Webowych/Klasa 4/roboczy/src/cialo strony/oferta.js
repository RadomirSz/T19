export default function Oferta(props){
    return(
        <div key={props.shoe.id} className="current-offer-card">
            <img src={props.shoe.image} alt={props.shoe.name} className="current-offer-image"/>
            <div><h2>{props.shoe.name}</h2>
            <h4>Stan magazynu: {props.shoe.stock}</h4>
            <button className="button-1">Sprzedaz detaliczna</button>
            <button className="button-2">Przyjecie tych butów</button>
            <p className="current-price">{props.shoe.price} zł</p>
            </div>
        </div>
    );
}