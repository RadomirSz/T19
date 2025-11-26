package com.example.a17_11;

import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import com.bumptech.glide.Glide;

import java.util.ArrayList;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class MainActivity extends AppCompatActivity {

    Button bt;
    ListView lv;
    ImageView iv;
    List<DogResponse> dogResponseList;
    List<DogResponse> dogRoomList;
    ArrayAdapter<DogResponse> aa;
    AppDatabase appDatabase;
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

        bt = findViewById(R.id.buttonLoad);
        lv = findViewById(R.id.listview);
        iv = findViewById(R.id.imageViewDog);

        appDatabase = AppDatabase.getInstance(this);

        dogResponseList = new ArrayList<DogResponse>();
        aa = new ArrayAdapter<>(this, androidx.appcompat.R.layout.support_simple_spinner_dropdown_item, dogResponseList);
        lv.setAdapter(aa);

        bt.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                getDogImage();
            }
        });
        lv.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {
                DogResponse dogResponse = dogResponseList.get(position);

                Glide.with(MainActivity.this).load(dogResponse.getMessage()).into(iv);
            }
        });

        lv.setOnItemLongClickListener(new AdapterView.OnItemLongClickListener() {
            @Override
            public boolean onItemLongClick(AdapterView<?> adapterView, View view, int i, long l) {
                new AlertDialog.Builder(MainActivity.this)
                        .setTitle("Usuwanie")
                        .setMessage("Czy na pewno?")
                        .setPositiveButton("Usuń", (dialogInterface, i1) -> {
                            DogResponse dogResponse = dogResponseList.get(i);
                            appDatabase.dogDao().deleteDog(dogResponse);
                            updateList();
                            Glide.with(MainActivity.this)
                                    .clear(iv);
                        })
                        .setNeutralButton("Anuluj", null )
                        .show();
                return false;
            }
        });
    }
    private void getDogImage() {
        DogApiService dogApiService = ApiClient.getClient().create(DogApiService.class);
        Call<DogResponse> call = dogApiService.getRandomDogImage();
        call.enqueue(new Callback<DogResponse>() {
            @Override
            public void onResponse(Call<DogResponse> call, Response<DogResponse> response) {
                if (response.isSuccessful()) {
                    String imageURL = response.body().getMessage();
                    //Glide.with(MainActivity.this).load(imageURL).into(iv);
                    appDatabase.dogDao().insertDog(response.body());
                    updateList();
                }
            }

            @Override
            public void onFailure(Call<DogResponse> call, Throwable t) {

            }
        });
    }
    private void updateList() {
        dogRoomList = appDatabase.dogDao().getAllDogs();
        dogResponseList.clear();
        for (var dog: dogRoomList) {
            dogResponseList.add(dog);
        }
        aa.notifyDataSetChanged();
    }
}


//        5. Glide Stack
//
//Nie ma czegoś takiego jak stack. Jest po prostu wywołanie:
//
//        Glide.with(MainActivity.this)
//    .load(imageUrl) <- String po prostu z https...
//        .into(imageViewDog);  <- W jaki kontener wkładamy