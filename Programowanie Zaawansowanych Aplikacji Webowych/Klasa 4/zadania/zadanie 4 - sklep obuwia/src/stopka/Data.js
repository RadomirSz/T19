export default function Data() {
    const dni = ["Poniedziałek","Wtorek","Środa","Czwartek","Piątek","Sobota","Niedziela"];
    const miesiace = ["stycznia", "lutego", "marca", "kwietnia", "maja", "czerwca", "lipca", "sierpnia", "września", "października", "listopada", "grudnia"];
    const today = new Date();
    let day = today.getDate();
    let month = today.getMonth()+1;
    let weekDay = today.getDay();
    if(month<10){
        month = "0"+month;
    }
    if(day<10){
        day = "0"+day;
    }
    const year = today.getFullYear();
    return(<span>{dni[weekDay-1]}: {day} {miesiace[month-1]} {year} roku</span>);
}