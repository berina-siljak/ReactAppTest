import React, { Component } from 'react';

export class Orders extends Component {
    static displayName = Orders.name;

    constructor(props) {
        super(props);
        this.state = { allorders: [], loading: true };
    }

    componentDidMount() {
        this.populateWeatherData();
    }

    static renderOrdersTable(allorders) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Order Number</th>
                        <th>Product Name</th>
                        <th>Category Name</th>
                        <th>Unit Price</th>
                        <th>Order Date</th>
                        <th>Required Date</th>
                    </tr>
                </thead>
                <tbody>
                    {
                        allorders.map(order =>
                        {
                            return order.product.map(products =>
                                <tr key={order.orderId}>
                                    <td>{order.orderId}</td>
                                        <td>{products.productName}</td>
                                        <td>{products.categoryName}</td>
                                    <td>{products.unitPrice}</td>
                                    <td>{order.orderDate}</td>
                                    <td>{order.requiredDate}</td>
                                    </tr>
                                )}
                        )}

                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Orders.renderOrdersTable(this.state.allorders);

        return (
            <div>
                <h1 id="tabelLabel" >Orders</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }
    async populateWeatherData() {
        const response = await fetch("https://localhost:44375/api/Orders/");
        const data = await response.json();
        this.setState({ allorders: data, loading: false });
    }

}
