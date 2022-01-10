library("ggpubr")
library(tidyverse)

Final <- read.csv("C:/Users/amira/Downloads/Adolescent - Sheet1.csv")

ggplot(data = Final) + 
  geom_boxplot(mapping = aes(x = Sex, y = LowDistraction1))