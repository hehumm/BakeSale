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

                    <div class="row">
                        <div class="col-md2">
                            <label for="itemSelection">Product selection</label>
                            <input type="text" class="form-control" id="itemSelection" aria-describedby="itemsToPurchase" placeholder="Select items for purchasing"></input>
                            <small id="itemsToPurchase" class="form-text text-muted">Example format for 2 brownies and 1 muffin: B2,M1</small>
                        </div>
                        <div class="col-md2 offset-2">
                            <label for="money">Payment</label>
                            <input type="number" class="form-control" id="money" aria-describedby="money"></input>
                            <small id="money" class="form-text text-muted">Insert the appropriate amount of money</small> 
                        </div>
                    </div> 
                    <div class="row">
                        <div class="col-3">
                            <p>Your chosen items:</p> 
                        </div>
                        <div class="col-2 offset-2">
                            <button className="btn btn-primary">Checkout</button>
                        </div>
                    </div>
                    <div class="row">
                    
                    </div>
            </div>
    );
}
}