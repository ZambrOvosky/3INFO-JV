-- MySQL Script generated by MySQL Workbench
-- Tue Apr 10 09:14:33 2018
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`tbFuncT`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`tbFuncT` (
  `id_funct` INT NOT NULL AUTO_INCREMENT,
  `name_funct` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id_funct`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`tbFunc`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`tbFunc` (
  `cod_func` INT NOT NULL AUTO_INCREMENT,
  `name_func` VARCHAR(256) NOT NULL,
  `ctps_nis_func` VARCHAR(45) NOT NULL,
  `ctps_num_func` VARCHAR(45) NOT NULL,
  `ctps_uf_func` VARCHAR(2) NOT NULL,
  `ctps_serie_func` VARCHAR(45) NOT NULL,
  `rg_num_func` VARCHAR(11) NOT NULL,
  `rg_uf_func` VARCHAR(2) NOT NULL,
  `cpf_func` VARCHAR(11) NOT NULL,
  `dn_func` DATE NOT NULL,
  `tel_func` VARCHAR(11) NOT NULL,
  `email_func` VARCHAR(256) NULL,
  `end_func` VARCHAR(256) NOT NULL,
  `foto_func` LONGBLOB NOT NULL,
  `comiss_func` VARCHAR(8) NOT NULL,
  `type_func` INT NOT NULL,
  PRIMARY KEY (`cod_func`),
  INDEX `fk_funct_idx` (`type_func` ASC),
  CONSTRAINT `fk_funct`
    FOREIGN KEY (`type_func`)
    REFERENCES `mydb`.`tbFuncT` (`id_funct`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`tbCli`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`tbCli` (
  `cpf_cli` VARCHAR(11) NOT NULL,
  `name_cli` VARCHAR(256) NOT NULL,
  `rg_num_cli` VARCHAR(11) NOT NULL,
  `rg_uf_cli` VARCHAR(2) NOT NULL,
  `dn_cli` DATE NOT NULL,
  `email_cli` VARCHAR(256) NULL,
  `tel_cli` VARCHAR(11) NOT NULL,
  PRIMARY KEY (`cpf_cli`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`tbArt`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`tbArt` (
  `cpf_art` VARCHAR(11) NOT NULL,
  `nome_art` VARCHAR(256) NOT NULL,
  `rg_num_art` VARCHAR(11) NOT NULL,
  `rg_uf_art` VARCHAR(2) NOT NULL,
  `gen_art` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`cpf_art`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
