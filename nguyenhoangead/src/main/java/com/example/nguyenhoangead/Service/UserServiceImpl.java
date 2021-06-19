package com.example.nguyenhoangead.Service;

import com.example.nguyenhoangead.Entity.UserEntity;
import com.example.nguyenhoangead.Responsitory.UserRepo;
import org.apache.catalina.User;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.stereotype.Service;

import java.awt.print.Pageable;
import java.util.List;
import java.util.Optional;

@Service
public class UserServiceImpl implements UserService {
    @Autowired
    UserRepo userRepo;
@Override
    public List<UserEntity> getAll(){return userRepo.findAll();}
@Override
    public UserEntity createUser(UserEntity p){return userRepo.save(p);}
@Override
    public void deleteProduct(int id){userRepo.deleteById(id);}
    @Override
public Optional<UserEntity> findUserById(int id){return userRepo.findById(id);}
@Override
    public List<UserEntity> getProductByName(String name, Pageable pageable){
return userRepo.findAllByBookname(name,pageable);
}

    @Override
    public List<UserEntity> getAllProduct(Pageable pageable) {
        return userRepo.findAll((org.springframework.data.domain.Pageable) pageable).getContent();
    }

    @Override
    public Page<UserEntity> finAll(Pageable pageable) {
        return userRepo.findAll((org.springframework.data.domain.Pageable) pageable);
    }

    //@Override
    //public Page<UserEntity> finAllByFirstNameContaining(String firstname, Pageable pageable) {
        //return userRepo.findAllBynameContaining(firstname, pageable);
    }




