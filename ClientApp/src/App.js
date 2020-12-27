import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import { Dashboard } from './components/Dashboard';
import { AdminLogin } from './components/AdminLogin';
import { AdminDashboard } from './components/AdminDashboard';
import { Teachers } from './components/Teachers';
import { AddTeacher } from './components/AddTeacher';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
      return (
          <div>
              <Route exact path='/' component={Home} />
              <Route exact path='/admin/login' component={AdminLogin} />
              <Route exact path='/admin/dashboard' component={AdminDashboard} />
              <Route exact path='/admin/teachers/add' component={AddTeacher} />
              <Route exact path='/admin/teachers' component={Teachers} />
          </div>
    );
  }
}
