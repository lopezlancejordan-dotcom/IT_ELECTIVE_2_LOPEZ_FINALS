// Node.js Express SSO Middleware for Issue #19 (Team S5 Guide)
const jwt = require('jsonwebtoken');
const SECRET_KEY = "YourSuperSecretKeyKeyHere12345";

function verifySsoMiddleware(req, res, next) {
    const authHeader = req.headers['authorization'];
    const token = authHeader && authHeader.split(' ')[1];
    
    if (!token) return res.status(401).json({ error: 'ERR_AUTH_001: Access token missing' });

    jwt.verify(token, SECRET_KEY, (err, user) => {
        if (err) return res.status(403).json({ error: 'ERR_AUTH_002: Invalid or expired token' });
        req.user = user;
        next();
    });
}

module.exports = verifySsoMiddleware;