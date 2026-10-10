<?php
// PHP SSO Token verification script for Issue #19 (Team S5 Guide)
require 'vendor/autoload.php';
use Firebase\JWT\JWT;
use Firebase\JWT\Key;

function verifySsoToken($jwtToken) {
    $secretKey = "YourSuperSecretKeyKeyHere12345";
    try {
        $decoded = JWT::decode($jwtToken, new Key($secretKey, 'HS256'));
        return ['status' => true, 'data' => $decoded];
    } catch (Exception $e) {
        return ['status' => false, 'error' => $e->getMessage()];
    }
}
?>