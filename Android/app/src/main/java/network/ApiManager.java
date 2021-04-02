package network;


import java.util.List;

import model.Wheather;
import retrofit2.Call;
import retrofit2.http.GET;

public interface ApiManager {

    String BASE_URL = "http://dataservice.accuweather.com/";



    @GET("data.json")
    Call<Wheather> getData();

    @GET("datas.json")
    Call<List<Wheather>> getDatas();

    @GET("/forecasts/v1/hourly/12hour/353412?apikey=rAdX4wWUVd7Ow22GjpugwU9Wp82d73Ka&language=vi-vn&metric=true")
    Call<List<Wheather>> getWeather();

    Call<List<Wheather>> gethour();
}