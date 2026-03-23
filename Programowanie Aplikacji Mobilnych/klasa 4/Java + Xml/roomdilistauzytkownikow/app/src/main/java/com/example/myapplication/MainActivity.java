package com.example.myapplication;

import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ListView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;
import androidx.lifecycle.ViewModelProvider;

import com.example.myapplication.data.AppDatabase;
import com.example.myapplication.data.User;
import com.example.myapplication.data.UserDAO;
import com.example.myapplication.repository.UserRepository;
import com.example.myapplication.viewmodel.UserViewModel;
import com.example.myapplication.viewmodel.UserViewModelFactory;

import java.util.ArrayList;
import java.util.List;

public class MainActivity extends AppCompatActivity {

    private EditText firstNameEditText;
    private EditText lastNameEditText;
    private EditText emailEditText;
    private Button saveButton;
    private ListView listView;
    private UserViewModel viewModel;
    private ArrayAdapter<String> adapter;
    private List<String> userList = new ArrayList<>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        // Inicjalizacja widoków
        firstNameEditText = findViewById(R.id.FirstName);
        lastNameEditText = findViewById(R.id.LastName);
        emailEditText = findViewById(R.id.Email);
        saveButton = findViewById(R.id.Save);
        listView = findViewById(R.id.listView);

        // Adapter do ListView
        adapter = new ArrayAdapter<>(this, android.R.layout.simple_list_item_1, userList);
        listView.setAdapter(adapter);

        // DI ręczne (Pure DI)
        UserDAO userDao = AppDatabase.getInstance(getApplication()).userDAO();
        UserRepository repository = new UserRepository(userDao);
        UserViewModelFactory factory = new UserViewModelFactory(repository);

        viewModel = new ViewModelProvider(this, factory).get(UserViewModel.class);

        // Obserwacja danych
        viewModel.getAllUsers().observe(this, users -> {
            userList.clear();

            for (User user : users) {
                userList.add(
                        user.getFirstName() + " " +
                                user.getLastName() + " (" +
                                user.getEmail() + ")"
                );
            }

            adapter.notifyDataSetChanged();
        });

        saveButton.setOnClickListener(v -> {

            String firstName = firstNameEditText.getText().toString();
            String lastName = lastNameEditText.getText().toString();
            String email = emailEditText.getText().toString();

            boolean success = viewModel.addUser(firstName, lastName, email);

            if (success) {
                Toast.makeText(this, "Zapisano użytkownika", Toast.LENGTH_SHORT).show();

                // Czyszczenie pól
                firstNameEditText.setText("");
                lastNameEditText.setText("");
                emailEditText.setText("");
            } else {
                Toast.makeText(this, "Błąd: sprawdź dane", Toast.LENGTH_SHORT).show();
            }

        });
    }
}