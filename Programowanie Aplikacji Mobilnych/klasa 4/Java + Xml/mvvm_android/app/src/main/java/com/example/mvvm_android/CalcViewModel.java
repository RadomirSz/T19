package com.example.mvvm_android;

import androidx.lifecycle.LiveData;
import androidx.lifecycle.MutableLiveData;
import androidx.lifecycle.ViewModel;

public class CalcViewModel extends ViewModel {
    private final MutableLiveData<String> result = new MutableLiveData<String>("");

    public LiveData<String> getResult(){
        return result;
    }
    public void add(String a, String b){
        result.setValue(a + b);
    }
}
