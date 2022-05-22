SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

CREATE DATABASE IF NOT EXISTS `Proyecto_Integrado` DEFAULT CHARACTER SET latin1 ;
USE `Proyecto_Integrado` ;

CREATE TABLE IF NOT EXISTS `Proyecto_Integrado`.`usuarios` (
  `id` INT(3) NOT NULL AUTO_INCREMENT,
  `nif` VARCHAR(9) NOT NULL,
  `nombre` VARCHAR(45) NOT NULL,
  `fecha_nac` DATE NOT NULL,
  `cargo` VARCHAR(45) NOT NULL,
  `puntos` INT(11) NOT NULL,
  `correo` VARCHAR(45) NOT NULL,
  `pswd` VARCHAR(45) NOT NULL,
  `foto` LONGBLOB NULL DEFAULT NULL,
  `borrado` BIT(1) NULL DEFAULT b'0',
  PRIMARY KEY (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

CREATE TABLE IF NOT EXISTS `Proyecto_Integrado`.`Correos` (
  `idCorreo` INT(3) NOT NULL AUTO_INCREMENT,
  `asunto` VARCHAR(100) NOT NULL,
  `cuerpo` LONGTEXT NOT NULL,
  `recipiente` VARCHAR(65) NOT NULL,
  `remitente` VARCHAR(65) NOT NULL,
  `fecha` DATETIME NOT NULL,
  `usuarios_id` INT(3) NOT NULL,
  PRIMARY KEY USING BTREE (`idCorreo`, `usuarios_id`),
  INDEX `fk_Correos_usuarios1_idx` (`usuarios_id`),
  CONSTRAINT `fk_Correos_usuarios1`
    FOREIGN KEY (`usuarios_id`)
    REFERENCES `Proyecto_Integrado`.`usuarios` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

CREATE TABLE IF NOT EXISTS `Proyecto_Integrado`.`pi_log` (
  `id_log` INT(3) NOT NULL AUTO_INCREMENT,
  `fecha` DATETIME NOT NULL,
  `accion` VARCHAR(150) NOT NULL,
  PRIMARY KEY (`id_log`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

CREATE TABLE IF NOT EXISTS `Proyecto_Integrado`.`reuniones` (
  `id` INT(3) NOT NULL AUTO_INCREMENT,
  `descripcion` LONGTEXT NOT NULL,
  `fecha` DATE NOT NULL,
  `hora` TIME NOT NULL,
  `nombre` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

CREATE TABLE IF NOT EXISTS `Proyecto_Integrado`.`tarea` (
  `id_tarea` INT(3) NOT NULL AUTO_INCREMENT,
  `titulo` VARCHAR(45) NOT NULL,
  `descripcion` VARCHAR(500) NOT NULL,
  `puntos` INT(11) NOT NULL,
  `asignado` BIT(1) NOT NULL,
  `finalizado` BIT(1) NOT NULL,
  `fecha_publicacion` DATE NOT NULL,
  `fecha_limite` DATE NOT NULL,
  `usuarios_id` INT(3) NULL DEFAULT NULL,
  PRIMARY KEY (`id_tarea`),
  INDEX `fk_tarea_usuarios1_idx` (`usuarios_id`),
  CONSTRAINT `fk_tarea_usuarios1`
    FOREIGN KEY (`usuarios_id`)
    REFERENCES `Proyecto_Integrado`.`usuarios` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

CREATE TABLE IF NOT EXISTS `Proyecto_Integrado`.`tienda` (
  `id_prod` INT(3) NOT NULL AUTO_INCREMENT,
  `nombre` VARCHAR(45) NULL DEFAULT NULL,
  `coste` INT(11) NOT NULL,
  `descripcion` VARCHAR(45) NOT NULL,
  `codigo` VARCHAR(20) NOT NULL,
  PRIMARY KEY (`id_prod`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = latin1;

CREATE TABLE IF NOT EXISTS `Proyecto_Integrado`.`usuarios_has_reuniones` (
  `usuarios_id` INT(3) NOT NULL,
  `reuniones_id` INT(3) NOT NULL,
  `id` INT(3) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`id`),
  INDEX `fk_usuarios_has_reuniones_reuniones1_idx` (`reuniones_id`),
  INDEX `fk_usuarios_has_reuniones_usuarios1_idx` (`usuarios_id`),
  CONSTRAINT `fk_usuarios_has_reuniones_reuniones1`
    FOREIGN KEY (`reuniones_id`)
    REFERENCES `Proyecto_Integrado`.`reuniones` (`id`)
    ON DELETE CASCADE
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_usuarios_has_reuniones_usuarios1`
    FOREIGN KEY (`usuarios_id`)
    REFERENCES `Proyecto_Integrado`.`usuarios` (`id`)
    ON DELETE CASCADE
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = LATIN1;

INSERT INTO usuarios VALUES(null,'11111111H','Administrador','0001-01-01','Administrador',999999,'admin@admin.com','admin123',null,0);

USE `Proyecto_Integrado`;

DELIMITER $$
USE `Proyecto_Integrado`$$
CREATE
DEFINER=`admin`@`%`
TRIGGER `Proyecto_Integrado`.`usuarios_after_insert`
AFTER INSERT ON `Proyecto_Integrado`.`usuarios`
FOR EACH ROW
BEGIN



INSERT INTO pi_log (fecha,accion) 

VALUES (NOW(),CONCAT("Registro de usuario ", NEW.nif));



END$$

USE `Proyecto_Integrado`$$
CREATE
DEFINER=`admin`@`%`
TRIGGER `Proyecto_Integrado`.`usuarios_after_update`
AFTER UPDATE ON `Proyecto_Integrado`.`usuarios`
FOR EACH ROW
BEGIN



INSERT INTO pi_log (fecha,accion) 

VALUES (NOW(),CONCAT("Modificación del usuario: ", new.nif));



END$$

USE `Proyecto_Integrado`$$
CREATE
DEFINER=`admin`@`%`
TRIGGER `Proyecto_Integrado`.`reuniones_after_insert`
AFTER INSERT ON `Proyecto_Integrado`.`reuniones`
FOR EACH ROW
BEGIN



INSERT INTO pi_log (fecha,accion) 

VALUES (NOW(),CONCAT("Creacion de nueva reunion con titulo: ", NEW.nombre));



END$$

USE `Proyecto_Integrado`$$
CREATE
DEFINER=`admin`@`%`
TRIGGER `Proyecto_Integrado`.`tarea_after_insert`
AFTER INSERT ON `Proyecto_Integrado`.`tarea`
FOR EACH ROW
BEGIN



INSERT INTO pi_log (fecha,accion) 

VALUES (NOW(),CONCAT("Creacion de nueva tarea ", NEW.titulo));





END$$


DELIMITER ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;