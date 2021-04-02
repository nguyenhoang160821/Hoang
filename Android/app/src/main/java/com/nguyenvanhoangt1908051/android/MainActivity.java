package com.nguyenvanhoangt1908051.android;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import android.os.Bundle;
import android.widget.TextView;

import java.util.List;

import model.Wheather;
import network.ApiManager;
import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class MainActivity extends AppCompatActivity {
    private RecyclerView rvHour;
    private TextView tvTem;
    private TextView tvSatus;
    private Object Wheather;
    private Object Call;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        tvTem = (TextView) findViewById(R.id.tvTem);
        tvSatus = (TextView) findViewById(R.id.tvStatus);
        getHours();
        LinearLayoutManager layoutManager = new LinearLayoutManager(this, LinearLayoutManager.HORIZONTAL, false);
        rvHour = (RecyclerView) findViewById(R.id.rvHour);
        setLayotMager(layoutManager);
    }

    private void setLayotMager(LinearLayoutManager layoutManager) {
    }

    private void getHours() {
        Retrofit retrofit = new Retrofit.Builder()
                .baseUrl(ApiManager.BASE_URL)
                .addConverterFactory(GsonConverterFactory.create())
                .build();
        ApiManager service = retrofit.create(ApiManager.class);
        service.gethour().enqueue(new Callback<List<Wheather>>() {
            @Override
            public void onResponse(Call<List<model.Wheather>> call, Response<List<model.Wheather>> response) {
                if (response.body() == null) return;
                List<Wheather> listWeather = response.body();
                HourAdapter adapter = new HourAdapter(MainActivity.this.Wheather);
                rvHour.setAdapter(adapter);
                Wheather wheather = listWeather.get(0);
                tvTem.setText(wheather.getTemperature().getValue().intValue() + "");
                tvSatus.setText(wheather.getIconPhrase());
            }

            @Override
            public void onFailure(Call<List<model.Wheather>> call, Throwable t) {

            }
        });
    }
}


