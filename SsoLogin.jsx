// React SSO Login Component for Issue #19 (Team S5 Guide)
import React, { useEffect } from 'react';

export default function SsoLogin() {
    useEffect(() => {
        const params = new URLSearchParams(window.location.search);
        const token = params.get('token');
        if (token) {
            localStorage.setItem('sso_token', token);
            window.location.href = '/dashboard';
        }
    }, []);

    return (
        <div className="container text-center mt-5">
            <h2>Authenticating via Single Sign-On...</h2>
            <p className="text-muted">Please wait while we verify your session credentials.</p>
        </div>
    );
}