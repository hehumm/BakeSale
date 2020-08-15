import React, { Component } from 'react';
import brownie from '../images/brownie.png'
import muffin from '../images/muffin.png'
import cakepop from '../images/cakepop.png'
import water from '../images/water.png'

export class BakeSale extends Component {
    static displayName = BakeSale.name;

    constructor(props) {
        super(props);
        this.state = { storeData: [] };
    }

    componentDidMount() {
        this.populateData();
    }

    static renderProducts() {
        return(
            <div class="row">
                <div class="card" style={{width: '18rem'}}>
                    <img src={brownie} class="card-img-top" alt="brownie image"/>
                    <div class="card-body">
                        <h5 class="card-title">Brownie</h5>
                        <p class="card-text">Price: 65c</p>
                        <p class="card-text">Stock: 48</p>
                        </div>
                </div>
                <div class="card" style={{width: '18rem'}}>
                    <img src={muffin} class="card-img-top" alt="muffin image"/>
                    <div class="card-body">
                        <h5 class="card-title">Muffin</h5>
                        <p class="card-text">Price: $1.00</p>
                        <p class="card-text">Stock: 36</p>
                    </div>
                </div>
                <div class="card" style={{width: '18rem'}}>
                    <img src={cakepop} class="card-img-top" alt="cakepop image"/>
                    <div class="card-body">
                        <h5 class="card-title">Cakepop</h5>
                        <p class="card-text">Price: $1.35</p>
                        <p class="card-text">Stock: 24</p> 
                    </div>
                </div>
                <div class="card" style={{width: '18rem'}}>
                    <img src={water} class="card-img-top" alt="water image"/>
                    <div class="card-body">
                        <h5 class="card-title">Water</h5>
                        <p class="card-text">Price: $1.50</p>
                        <p class="card-text">Stock: 30</p>
                    </div>
                </div>
            </div>
        );
    }

    render() {
        return(
            <div>
                <div>
                    <p>Lorem epsim mida iganes</p>
                    { this.storeData }
                </div>
            </div>
        );
        /*return (
            <div>
                <h1>Bake Sale</h1>

                <p>Welcome to our bake sale. Thanks for supporting us!</p>

                <p><strong>Currently on sale:{ BakeSale.renderProducts() }</strong></p>

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
        );*/
    }

    async populateData() {
        const response = await fetch('products');
        const data = await response.json();
        this.setState({ storeData: data });
    }
}