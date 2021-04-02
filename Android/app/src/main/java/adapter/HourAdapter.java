package adapter;

import android.app.Activity;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.recyclerview.widget.RecyclerView;

import com.bumptech.glide.Glide;
import com.nguyenvanhoangt1908051.android.R;

import java.util.List;

import model.Wheather;

class HomeAdapter extends RecyclerView.Adapter {

    private Activity activity;
    private List<Wheather> listItem;

    public HomeAdapter(Activity activity, List<Wheather> listItem) {
        this.activity = activity;
        this.listItem = listItem;
    }

    public void reloadData(List<Wheather> list) {
        this.listItem = list;
        notifyDataSetChanged();
    }

    @NonNull
    @Override
    public RecyclerView.ViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        View itemView = activity.getLayoutInflater().inflate(R.layout.item_hour, parent, false);
        HomeHolder homeHolder = new HomeHolder(itemView);
        return homeHolder;
    }

    @Override
    public void onBindViewHolder(@NonNull RecyclerView.ViewHolder holder, int position) {
        HomeHolder homeHolder = (HomeHolder) holder;
        Wheather model = listItem.get(position);
        homeHolder.tvDate.setText(model.getDateTime());
        homeHolder.tvContent.setText(model.getWeatherIcon());
        homeHolder.tvTitle.setText(model.getIconPhrase());
        Glide.with(activity).load(model.getWeatherIcon()).into(homeHolder.ivCover);
        String url="";

    }

    @Override
    public int getItemCount() {
        return listItem.size();
    }

    public class HomeHolder extends RecyclerView.ViewHolder {
        TextView tvDate, tvTitle, tvContent;
        ImageView ivCover;

        public HomeHolder(@NonNull View itemView) {
            super(itemView);
            tvDate = itemView.findViewById(R.id.tvLocation);
            tvTitle = itemView.findViewById(R.id.tvStatus);
            tvContent = itemView.findViewById(R.id.tvTem);
            ivCover = itemView.findViewById(R.id.tvTime);
        }
    }
}
