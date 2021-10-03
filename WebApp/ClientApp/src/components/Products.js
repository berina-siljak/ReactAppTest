import React, { Component } from 'react';

export class Products extends Component {
    static displayName = Products.name;

    constructor(props) {
        super(props);
        this.state = { allproducts: [], loading: true };
    }

    componentDidMount() {
        this.populateWeatherData2();
    }

    static renderProductsTable(allproducts) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Product Name</th>
                        <th>Supplier</th>
                        <th>Quantity Per Unit</th>
                        <th>Unit Price</th>
                        <th>Units In Stock</th>
                        <th>Units On Order</th>

                    </tr>
                </thead>
                <tbody>
                  
                    {
                        allproducts.map(product =>
                            <tr key={product.productId}>
                                <td>{product.productName}</td>
                                <td>{product.supplier.companyName}</td>
                                <td>{product.quantityPerUnit}</td>
                                <td>{product.unitPrice}</td>
                                <td>{product.unitsInStock}</td>
                                <td>{product.unitsOnOrder}</td>

                            </tr>
                        )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Products.renderProductsTable(this.state.allproducts);

        return (
            <div>
                <h1 id="tabelLabel" >Products</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }
    async populateWeatherData2() {
        const response = await fetch("https://localhost:44375/api/Products/");
        const data = await response.json();
        this.setState({ allproducts: data, loading: false });
    }

}
