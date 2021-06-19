package com.example.nguyenhoangead.Entity;

import javax.persistence.*;

@Entity
@Table(name = "book")
public class UserEntity {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
private int bookid;
@Column(name = "bookname")
private String bookname;
@Column(name = "publisher")
private String publisher;
@Column(name = "author")
private String author;

    public int getBookid() {
        return bookid;
    }

    public void setBookid(int bookid) {
        this.bookid = bookid;
    }

    public String getBookname() {
        return bookname;
    }

    public void setBookname(String bookname) {
        this.bookname = bookname;
    }

    public String getPublisher() {
        return publisher;
    }

    public void setPublisher(String publisher) {
        this.publisher = publisher;
    }

    public String getAuthor() {
        return author;
    }

    public void setAuthor(String author) {
        this.author = author;
    }

    public String getGenre() {
        return genre;
    }

    public void setGenre(String genre) {
        this.genre = genre;
    }

    @Column(name = "genre")
    private String genre;

}
