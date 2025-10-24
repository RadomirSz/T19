function Data() {
    const today = new Date();
    const day = today.getDate();
    let month = today.getMonth()+1;
    if(month<10){
        month = "0"+month;
    }
    const year = today.getFullYear();
    return(<div>{day}.{month}.{year}</div>);
}

export default Data;