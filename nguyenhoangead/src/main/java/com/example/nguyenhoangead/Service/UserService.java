package com.example.nguyenhoangead.Service;

import com.example.nguyenhoangead.Entity.UserEntity;
import org.apache.catalina.User;
import org.springframework.data.domain.Page;

import java.awt.print.Pageable;
import java.util.List;
import java.util.Optional;

public interface UserService {
    List<UserEntity> getAll();
    UserEntity createUser(UserEntity p );
    void deleteProduct(int id);
    Optional<UserEntity> findUserById(int id);
    List<UserEntity> getProductByName(String name, Pageable pageable);
List<UserEntity> getAllProduct(Pageable pageable);
Page<UserEntity> finAll(Pageable pageable);
//Page<UserEntity> finAllByFirstNameContaining(String firstname,Pageable pageable);
}
