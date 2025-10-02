import React, { Component } from "react";

class BookOpis extends Component {
    constructor(props) {
        super(props);
        this.state = {
            book: [
                {id:0,title:"hobbit",author:"J. R. Tolkien", pages:"300"},
                {id:1,title:"1984",author:"George Orwell", pages:"328"},
                {id:2,title:"Pan Tadeusz",author:"Adam Mickiewicz", pages:"340"}
            ]
        }
    }
    render(){
        return(
            <div>
                {this.state.book.map((item,index)=>(
                    <ol key={index}>
                        <h1>tytul: {item.title}</h1>
                        <h2>autor: {item.author}</h2>
                        <h4>ilosc stron: {item.pages}</h4>
                    </ol>   
                ))}
            </div>
        )
    }
}

export default BookOpis;