package com.example.nguyenhoangead.Responsitory;

import com.example.nguyenhoangead.Entity.UserEntity;
import org.apache.catalina.User;
import org.springframework.data.domain.Page;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;

import java.awt.print.Pageable;
import java.util.List;

public interface UserRepo extends JpaRepository<UserEntity,Integer> {
@Query("select p from UserEntity p where p.bookname like %:name%")
    List<UserEntity> findAllByBookname(String name, Pageable pageable);
    //Page<UserEntity> findAllBynameContaining(String firstname, Pageable pageable);
}
