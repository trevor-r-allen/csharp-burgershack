use trevorclassroom;

-- CREATE TABLE burgers
-- (
--   id INT NOT NULL AUTO_INCREMENT,
--   name VARCHAR(255) NOT NULL UNIQUE,
--   description VARCHAR(255),
--   price DECIMAL(6, 2) NOT NULL,
--   PRIMARY KEY (id)
-- );

-- CREATE TABLE sides
-- (
--   id INT NOT NULL AUTO_INCREMENT,
--   name VARCHAR(255) NOT NULL UNIQUE,
--   description VARCHAR(255),
--   price DECIMAL(6, 2) NOT NULL,
--   PRIMARY KEY (id)
-- );

-- CREATE TABLE drinks
-- (
--   id INT NOT NULL AUTO_INCREMENT,
--   name VARCHAR(255) NOT NULL UNIQUE,
--   description VARCHAR(255),
--   price DECIMAL(6, 2) NOT NULL,
--   PRIMARY KEY (id)
-- );

(


PRIMARY KEY(id),
FOREIGN KEY(otherId)
  REFERENCES otherCollectionName (id)
  ON DELETE CASCADE
)

-- DANGER ZONE

-- ALTER A TABLE
-- ALTER TABLE collectionName
    -- DROP COLUMN currentPropName
    -- or
    -- MODIFY COLUMN currentPropName newPropName
    -- or
    -- ADD COLUMN newPropName DATATYPE

-- DELETE ALL DATA WITHIN A COLLECTION
-- DELETE FROM collectionName;

-- DELETE ENTIRE COLLECTION TABLE