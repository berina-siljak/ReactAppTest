import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Products } from './components/Products';
import { Orders } from './components/Orders';
import { Suppliers } from './components/Suppliers';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/products' component={Products} />
        <Route path='/suppliers' component={Suppliers} />
        <Route path='/orders' component={Orders} />
      </Layout>
    );
  }
}
