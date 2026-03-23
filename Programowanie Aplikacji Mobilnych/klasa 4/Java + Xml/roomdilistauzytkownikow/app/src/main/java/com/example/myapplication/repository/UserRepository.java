package com.example.myapplication.repository;

import com.example.myapplication.data.User;
import com.example.myapplication.data.UserDAO;

import java.util.List;

public class UserRepository {
    private final UserDAO userDAO;
    public UserRepository(UserDAO userdao){
        this.userDAO = userdao;
    }

    public void insert(User user){
        userDAO.insert(user);
    }

    public List<User> getAllUsers(){
        return userDAO.getAllUsers();
    }
}
