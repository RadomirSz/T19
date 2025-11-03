import React, { Component } from 'react';

class Menu extends Component {
    constructor(props) {
        super(props);
        this.state = {
            items: props.productList
        }
    }
    render() {
        return(
            <div className="Menu-item">
                <h3>Menu: {this.props.name}</h3>
                <ol>
                    {this.state.items.map((item, index) => (
                        <li key={index}>{item}</li> 
                    ))}
                </ol>
            </div>
        )
    }
}

export default Menu;