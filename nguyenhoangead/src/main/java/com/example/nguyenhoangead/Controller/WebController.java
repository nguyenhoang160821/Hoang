package com.example.nguyenhoangead.Controller;

import com.example.nguyenhoangead.Entity.UserEntity;
import com.example.nguyenhoangead.Service.UserService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.data.domain.Page;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.servlet.ModelAndView;

import java.awt.print.Pageable;
import java.util.Optional;

@Controller
public class WebController {
    @Autowired
    UserService userService;
@GetMapping({"/","index"})
public String index(Model model){
String mes ="Hello Hoang";
model.addAttribute("message",mes);
return "index";
}
    @GetMapping("/adduser")
    public String addUser(Model model) {
        UserEntity userEntity = new UserEntity();
        model.addAttribute("user", userEntity);
        return "adduser";
    }

    @GetMapping("/listuser")
    public ModelAndView listUser(@RequestParam("s") Optional<String> s, Pageable pageable) {
        Page<UserEntity> users;
        if(s.isPresent()){
            //users = userService.finAllByFirstNameContaining(s.get(), pageable);
        } else {
            users = userService.finAll(pageable);
        }
        ModelAndView modelAndView = new ModelAndView("listuser");
        //modelAndView.addObject("users", users);
        return modelAndView;
    }
    @PostMapping("/adduser")
    public String addUser(@ModelAttribute UserEntity userEntity, Model model) {
        userService.createUser(userEntity);
        return "redirect:/listuser";
    }

    @GetMapping("/delete/{id}")
    public String deleteUser(@PathVariable("id") int id, Model model) {
        userService.deleteProduct(id);
        return "redirect:/listuser";
    }

    @GetMapping("/edit/{id}")
    public String editUser(@PathVariable("id") int id, Model model) {
        Optional<UserEntity> userEdit = userService.findUserById(id);
        userEdit.ifPresent(user -> model.addAttribute("user", user));
        return "edituser";
    }



}
