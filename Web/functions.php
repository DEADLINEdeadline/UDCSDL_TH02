<?php 
function findUserByEmail($email) {
  global $db;
  $stmt = $db->prepare("SELECT * FROM users WHERE email = ?");
  $stmt->execute(array(strtolower($email)));
  $user = $stmt->fetch(PDO::FETCH_ASSOC);
  return $user;
}

function findUserById($id) {
  global $db;
  $stmt = $db->prepare("SELECT * FROM users WHERE id = ?");
  $stmt->execute(array($id));
  $user = $stmt->fetch(PDO::FETCH_ASSOC);
  return $user;
}

function createUser($fullname, $email, $password) {
  global $db;
  $stmt = $db->prepare("INSERT INTO users (email, password, fullname) VALUE (?, ?, ?)");
  $stmt->execute(array($email, $password, $fullname));
  return $db->lastInsertId();
}
function updatefullname($fullname,$id) {
  global $db;
  $stmt = $db->prepare("UPDATE users SET fullname = ? WHERE id = ?");
  $stmt->execute(array($fullname,$id));
}
function updatephone($phone,$id) {
  global $db;
  $stmt = $db->prepare("UPDATE users SET Phone = ? WHERE id = ?");
  $stmt->execute(array($phone,$id));
}
function updatepass($password,$id) {
  global $db;
  $stmt = $db->prepare("UPDATE users SET password = ? WHERE id = ?");
  $stmt->execute(array($password,$id));
}
function upstatus($uid,$stt) {
  global $db;
  $stmt = $db->prepare("INSERT INTO posts (userId, content) VALUE (?, ?)");
  $stmt->execute(array($uid,$stt));
}
function getstatus($id) {
  global $db;
  $stmt = $db->prepare("SELECT * FROM users u JOIN posts p ON u.id = p.userId and p.id = $id");
  $stmt->execute(array($id));
  $user = $stmt->fetch(PDO::FETCH_ASSOC);
  return $user;
}