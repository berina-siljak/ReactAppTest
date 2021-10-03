import React, { Component } from 'react';

export class Suppliers extends Component {
    static displayName = Suppliers.name;

    constructor(props) {
        super(props);
        this.state = { allsuppliers: [], loading: true };
    }

    componentDidMount() {
        this.populateWeatherData2();
    }

    static renderSuppliersTable(allsuppliers) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Company Name</th>
                        <th>Contact Name</th>
                        <th>Contact Title</th>
                        <th>Address</th>
                        <th>City</th>

                    </tr>
                </thead>
                <tbody>
             
                    {
                        allsuppliers.map(supplier =>
                            <tr key={supplier.supplierId}>
                                <td>{supplier.companyName}</td>
                                <td>{supplier.contactName}</td>
                                <td>{supplier.contactTitle}</td>
                                <td>{supplier.address}</td>
                                <td>{supplier.city}</td>

                            </tr>
                        )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Suppliers.renderSuppliersTable(this.state.allsuppliers);

        return (
            <div>
                <h1 id="tabelLabel" >Suppliers</h1>
                <p>This component demonstrates fetching data from the server.</p>
                {contents}
            </div>
        );
    }
    async populateWeatherData2() {
        const response = await fetch("https://localhost:44375/api/Suppliers/");
        const data = await response.json();
        this.setState({ allsuppliers: data, loading: false });
    }

}
