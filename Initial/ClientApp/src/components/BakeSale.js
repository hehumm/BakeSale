import React, { Component } from 'react';

export class BakeSale extends Component {
    static displayName = BakeSale.name;

    constructor(props) {
        super(props);
        this.state = { currentCount: 0 };
        this.incrementCounter = this.incrementCounter.bind(this);
    }

    incrementCounter() {
        this.setState({
            currentCount: this.state.currentCount + 1
        });
    }

    render() {
        return (
            <div>
            <h1>Bake Sale</h1>

            <p>Welcome to our bake sale. Thanks for supporting us!</p>

            <p><strong>Currently on sale:</strong></p> 

                <div class="form-group">
                    <label for="itemSelection">Product selection</label>
                    <input type="text" class="form-control" id="itemSelection" aria-describedby="itemsToPurchase" placeholder="Select items for purchasing"></input>
                    <small id="itemsToPurchase" class="form-text text-muted">Example format for 2 brownies and 1 muffin: B2,M1</small>

                    <label for="money">Payment</label>
                    <input type="number" class="form-control" id="money" placeholder="Insert the appropriate amount of money"></input>
                </div> 
            </div>
    );
}
}