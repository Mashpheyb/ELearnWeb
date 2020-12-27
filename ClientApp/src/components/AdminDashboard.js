import React, { Component } from 'react';
import { Route } from 'react-router';
import { AdminLayout } from './AdminLayout';

export class AdminDashboard extends Component {
    static displayName = AdminDashboard.name;

    render() {
        return (
            <AdminLayout>
                <div>
                    <h1>Dashboard</h1>
                </div>
            </AdminLayout>
        );
    }
}
