use trevorclassroom;

CREATE TABLE burgers
(
  id INT AUTO_INCREMENT,
  name VARCHAR(255) NOT NULL UNIQUE,
  description VARCHAR(255),
  price DECIMAL(6, 2) NOT NULL,
  PRIMARY KEY (id)
);