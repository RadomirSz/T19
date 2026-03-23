package com.example.myapplication.viewmodel;

import androidx.lifecycle.LiveData;
import androidx.lifecycle.MutableLiveData;
import androidx.lifecycle.ViewModel;

import com.example.myapplication.data.User;
import com.example.myapplication.repository.UserRepository;

import java.util.List;

public class UserViewModel extends ViewModel {

    private final UserRepository repository;
    private final MutableLiveData<List<User>> allUsers = new MutableLiveData<List<User>>();

    public UserViewModel(UserRepository repository) {
        this.repository = repository;
        loadUsers();
    }
    public LiveData<List<User>> getAllUsers() {
        return allUsers;
    }

    public boolean addUser(String firstName, String lastName, String email) {

        // Walidacja
        if (firstName == null || firstName.trim().isEmpty()) return false;
        if (lastName == null || lastName.trim().isEmpty()) return false;
        if (email == null || email.trim().isEmpty()) return false;
        if (!email.contains("@")) return false;

        User user = new User(firstName, lastName, email);
        repository.insert(user);
        loadUsers();
        return true;
    }

    public void loadUsers(){
        allUsers.postValue(repository.getAllUsers());
    }
}