import React, { Component } from 'react';
import brownie from '../images/brownie.png'
import muffin from '../images/muffin.png'
import cakepop from '../images/cakepop.png'
import water from '../images/water.png'

export class BakeSale extends Component {
    static displayName = BakeSale.name;

    constructor(props) {
        super(props);
        this.state = { storeData: [], loading: true };
    }

    componentDidMount() {
        this.populateData();
    }

    static renderProducts(data) {
        return(
            <div class="row">
                <div>
                    {data.map(object =>
                        <div class="card" style={{width: '18rem'}}>
                            <img src={object.image} class="card-img-top" alt="product image"/>
                            <div class="card-body">
                                <h5 class="card-title">{object.name}</h5>
                                <p class="card-text">Price:{object.price.amount}</p>
                                <p class="card-text">Stock:{object.stock}</p>
                            </div>
                        </div>
                    )}
                </div>
            </div>
        );
    }

    static renderActions(){
        return(
            <div>
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

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
        : BakeSale.renderProducts(this.state.storeData);
        let actions = BakeSale.renderActions();
        return(
            <div>
                <div>
                    <h1>Bake Sale</h1>
                    <p>Welcome to our bake sale. Thanks for supporting us!</p>
                    <p><strong>Currently on sale:{ contents }</strong></p>
                    <div>{ actions }</div>
                </div> 
            </div>
        );
    }

    async populateData() {
        const response = await fetch('products');
        const data = await response.json();
        this.setState({ storeData: data, loading: false });
    }
}