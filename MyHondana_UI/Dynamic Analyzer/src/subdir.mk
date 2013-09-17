################################################################################
# Automatically-generated file. Do not edit!
################################################################################

# Add inputs and outputs from these tool invocations to the build variables 
CPP_SRCS += \
../src/AppResourceId.cpp \
../src/CoverFlowPanel.cpp \
../src/MyHondana.cpp \
../src/MyHondanaDetailForm.cpp \
../src/MyHondanaEntry.cpp \
../src/MyHondanaFormFactory.cpp \
../src/MyHondanaFrame.cpp \
../src/MyHondanaMainForm.cpp \
../src/MyHondanaMarketForm.cpp \
../src/MyHondanaPanelFactory.cpp \
../src/SceneRegister.cpp 

OBJS += \
./src/AppResourceId.o \
./src/CoverFlowPanel.o \
./src/MyHondana.o \
./src/MyHondanaDetailForm.o \
./src/MyHondanaEntry.o \
./src/MyHondanaFormFactory.o \
./src/MyHondanaFrame.o \
./src/MyHondanaMainForm.o \
./src/MyHondanaMarketForm.o \
./src/MyHondanaPanelFactory.o \
./src/SceneRegister.o 

CPP_DEPS += \
./src/AppResourceId.d \
./src/CoverFlowPanel.d \
./src/MyHondana.d \
./src/MyHondanaDetailForm.d \
./src/MyHondanaEntry.d \
./src/MyHondanaFormFactory.d \
./src/MyHondanaFrame.d \
./src/MyHondanaMainForm.d \
./src/MyHondanaMarketForm.d \
./src/MyHondanaPanelFactory.d \
./src/SceneRegister.d 


# Each subdirectory must supply rules for building sources it contributes
src/%.o: ../src/%.cpp
	@echo 'Building file: $<'
	@echo 'Invoking: C++ Compiler'
	clang++.exe -I"pch" -D_USE_DA_ -D_DEBUG -I"C:\tizen-sdk/library" -I"C:\tizenworkspace\MyHondana\inc" -O0 -g3 -Wall -c -fmessage-length=0 -g -pg -funwind-tables -finstrument-functions -target i386-tizen-linux-gnueabi -gcc-toolchain "C:/tizen-sdk/tools/smart-build-interface/../i386-linux-gnueabi-gcc-4.5/" -ccc-gcc-name i386-linux-gnueabi-g++ -march=i386 -Wno-gnu -fPIE --sysroot="C:/tizen-sdk/platforms/tizen2.1/rootstraps/tizen-emulator-2.1.native" -I"C:/tizen-sdk/platforms/tizen2.1/rootstraps/tizen-emulator-2.1.native/usr/include/libxml2" -I"C:\tizen-sdk\library" -I"C:/tizen-sdk/platforms/tizen2.1/rootstraps/tizen-emulator-2.1.native/usr/include" -I"C:/tizen-sdk/platforms/tizen2.1/rootstraps/tizen-emulator-2.1.native/usr/include/osp" -D_APP_LOG -MMD -MP -MF"$(@:%.o=%.d)" -MT"$(@:%.o=%.d)" -o "$@" "$<"
	@echo 'Finished building: $<'
	@echo ' '


