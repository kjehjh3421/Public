S/W Version Information
Model: SGH-N055
Tizen-Version: 2.2.0
Build-Number: N055OMEAMG2
Build-Date: 2013.07.04 20:54:23

Crash Information
Process Name: MyHondana
PID: 25351
Date: 2013-07-12 18:42:07(GMT+0900)
Executable File Path: /opt/apps/docomo6003/bin/MyHondana
This process is multi-thread process
pid=25351 tid=25351
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 25351, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0xbeea3418
r2   = 0x00000001, r3   = 0xbeea3418
r4   = 0xfffed9bc, r5   = 0xb41f2598
r6   = 0xbeea3418, r7   = 0x02018d28
r8   = 0xa00009cb, r9   = 0xbeea37dc
r10  = 0x00000001, fp   = 0xbeea3658
ip   = 0xb41f44ac, sp   = 0xbeea2df0
lr   = 0xb3d54af7, pc   = 0xb3b8b408
cpsr = 0x88010030

Memory Information
MemTotal:  2063912 KB
MemFree:   1147436 KB
Buffers:     47660 KB
Cached:     469392 KB
VmPeak:     226544 KB
VmSize:     172176 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:      113396 KB
VmRSS:      113396 KB
VmData:      66324 KB
VmStk:         136 KB
VmExe:          32 KB
VmLib:       66244 KB
VmPTE:         206 KB
VmSwap:          0 KB

Maps Information
00008000 00010000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
00018000 00070000 rw-p [heap]
00070000 02452000 rw-p [heap]
ae7ae000 ae7b0000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b05cd000 b05d1000 r-xp /usr/lib/bufmgr/libtbm_exynos4412.so.0.0.0
b05da000 b0dd9000 rwxp [stack:25353]
b0dd9000 b0f27000 r-xp /usr/lib/r3p2/libMali.so
b0f33000 b0f5b000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnueabi-armv7l-1.7.99/module.so
b0f5f000 b0f7d000 r-xp /usr/lib/osp/libtestbuddy.so.1.0
b0f8c000 b0f96000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b12d0000 b131c000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b1325000 b132a000 r-xp /usr/lib/libjson.so.0.0.1
b1332000 b1336000 r-xp /usr/lib/liblocation-pos-log.so
b133e000 b1350000 r-xp /usr/lib/libmmfile_utils.so.0.0.0
b1358000 b135a000 r-xp /usr/lib/libmedia-hash.so.1.0.0
b1362000 b1367000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b136f000 b137a000 r-xp /usr/lib/libdrm-trusted.so.0.0.52
b1382000 b1384000 r-xp /usr/lib/libmedia-svc-hash.so.1.0.0
b138c000 b1399000 r-xp /usr/lib/libdrm-client.so.0.0.90
b13a2000 b13aa000 r-xp /usr/lib/lib_SamsungRec_V03010.so
b13cc000 b1403000 r-xp /usr/lib/libpulse.so.0.16.2
b140b000 b146f000 r-xp /usr/lib/libasound.so.2.0.0
b1479000 b147c000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b1485000 b1489000 r-xp /usr/lib/libascenario-0.2.so.0.0.0
b1492000 b14af000 r-xp /usr/lib/libavsysaudio.so.0.0.1
b14b7000 b14bc000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b14c4000 b14f1000 r-xp /usr/lib/libSLP-location.so.0.0.0
b14fa000 b1503000 r-xp /usr/lib/libdownload-provider-interface.so.1.0.7
b150b000 b150f000 r-xp /usr/lib/libmmffile.so.0.0.0
b1517000 b151e000 r-xp /usr/lib/libmedia-utils.so.0.0.0
b1527000 b1541000 r-xp /usr/lib/libmedia-thumbnail.so.1.0.0
b1549000 b1564000 r-xp /usr/lib/libmedia-service.so.1.0.0
b156c000 b1577000 r-xp /usr/lib/libmdm-common.so.1.0.37
b157f000 b158d000 r-xp /usr/lib/libbookmark-adaptor.so.0.2.7
b1596000 b159d000 r-xp /usr/lib/libenchant.so.1.6.1
b15a5000 b15a8000 r-xp /usr/lib/libcapi-telephony-network-info.so.0.1.8
b15b1000 b15ba000 r-xp /usr/lib/libcapi-system-sensor.so.0.1.17
b15c3000 b15c7000 r-xp /usr/lib/libmmfsession.so.0.0.0
b15d0000 b15df000 r-xp /usr/lib/libmmfsound.so.0.1.0
b15e7000 b15ec000 r-xp /usr/lib/libmemenv.so.1.1.0
b15f4000 b1632000 r-xp /usr/lib/libleveldb.so.1.1.0
b163b000 b1665000 r-xp /usr/lib/libgstaudio-0.10.so.0.25.0
b166e000 b1670000 r-xp /usr/lib/libsecfw.so
b1678000 b1681000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.0
b168c000 b169b000 r-xp /usr/lib/libgstvideo-0.10.so.0.25.0
b16a3000 b16bb000 r-xp /usr/lib/libgstpbutils-0.10.so.0.25.0
b16bd000 b16ca000 r-xp /usr/lib/libgstinterfaces-0.10.so.0.25.0
b16d3000 b16dc000 r-xp /usr/lib/libgstapp-0.10.so.0.25.0
b16e4000 b1726000 r-xp /usr/lib/libgstbase-0.10.so.0.30.0
b172f000 b17cb000 r-xp /usr/lib/libgstreamer-0.10.so.0.30.0
b17d7000 b17fc000 r-xp /usr/lib/libxslt.so.1.1.16
b1805000 b1807000 r-xp /usr/lib/libewebkit2-ext.so.1.0.2
b180f000 b1817000 r-xp /usr/lib/libui-gadget-1.so.0.1.0
b181f000 b182a000 r-xp /usr/lib/libcapi-location-manager.so.0.1.12
b1832000 b1835000 r-xp /usr/lib/libcapi-web-url-download.so.0.1.0
b183d000 b1842000 r-xp /usr/lib/libcapi-media-metadata-extractor.so
b184a000 b1871000 r-xp /usr/lib/libcapi-content-media-content.so.0.2.70
b1879000 b188f000 r-xp /usr/lib/osp/libosp-locations.so.1.2.1.0
b1898000 b18d5000 r-xp /usr/lib/libmdm.so.1.0.63
b18dd000 b18f2000 r-xp /usr/lib/libnetwork.so.0.0.0
b18fa000 b1903000 r-xp /usr/lib/libcapi-web-favorites.so
b190b000 b2b63000 r-xp /usr/lib/libewebkit2.so.0.10.144.6
b2c56000 b2ca9000 r-xp /usr/lib/osp/libosp-content.so.1.2.2.0
b2cb2000 b2cc9000 r-xp /usr/lib/libwifi-direct.so.0.0
b2cd1000 b2cd9000 r-xp /usr/lib/libcapi-network-wifi.so.0.1.7
b2ce1000 b2cea000 r-xp /usr/lib/libcapi-network-tethering.so.0.1.0
b2cf2000 b2cfc000 r-xp /usr/lib/libcapi-network-connection.so.0.1.10
b2d04000 b2d68000 r-xp /usr/lib/osp/libosp-web.so.1.2.2.0
b2d75000 b2e2a000 r-xp /usr/lib/osp/libosp-net.so.1.2.2.0
b2e37000 b2e51000 r-xp /usr/lib/osp/libosp-json.so.1.2.2.0
b2e5a000 b2e78000 r-xp /usr/lib/osp/libosp-image.so.1.2.2.0
b2e84000 b2e8a000 r-xp /usr/lib/libUMP.so
b2e99000 b2ee9000 r-xp /opt/usr/apps/docomo6003/bin/MyHondana.exe
b2ef3000 b2f3b000 r-xp /usr/lib/libosp-env-config.so.SOVERSION
b2f43000 b2fd3000 r-xp /usr/lib/libCOREGL.so.3.0
b2fdd000 b2fe0000 r-xp /usr/lib/libmm_ta.so.0.0.0
b2fe8000 b2fef000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b2ff8000 b3007000 r-xp /usr/lib/libICE.so.6.3.0
b3011000 b3016000 r-xp /usr/lib/libSM.so.6.0.1
b301e000 b301f000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3027000 b3029000 r-xp /usr/lib/libledplayer.so.0.1
b3031000 b3037000 r-xp /usr/lib/libxcb-render.so.0.0.0
b303f000 b3040000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b3049000 b3050000 r-xp /usr/lib/libGLESv2.so.2.0
b3058000 b309f000 r-xp /usr/lib/libtiff.so.5.1.0
b30aa000 b30d3000 r-xp /usr/lib/libturbojpeg.so
b30ec000 b30f0000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b30f9000 b30ff000 r-xp /usr/lib/libgif.so.4.1.6
b3107000 b3129000 r-xp /usr/lib/libavutil.so.51.73.101
b3138000 b3166000 r-xp /usr/lib/libswscale.so.2.1.101
b316f000 b3466000 r-xp /usr/lib/libavcodec.so.54.59.100
b378d000 b37a6000 r-xp /usr/lib/libpng12.so.0.50.0
b37af000 b37b6000 r-xp /usr/lib/libfeedback.so.0.1.4
b37bf000 b37d2000 r-xp /usr/lib/libtts.so
b37db000 b37dd000 r-xp /usr/lib/libEGL.so.1.4
b37e5000 b389c000 r-xp /usr/lib/libcairo.so.2.11200.12
b38a6000 b38bf000 r-xp /usr/lib/osp/libosp-image-core.so.1.2.2.0
b38c9000 b38cd000 r-xp /usr/lib/libss-client.so.1.0.0
b38d6000 b38d8000 r-xp /opt/usr/apps/docomo6003/bin/MyHondana
b38e0000 b418c000 r-xp /usr/lib/osp/libosp-uifw.so.1.2.2.0
b41fd000 b4206000 r-xp /usr/lib/libslp_devman_plugin.so
b420f000 b4211000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b4219000 b421c000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b4224000 b4227000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b422f000 b423c000 r-xp /usr/lib/libmodem.so.0.0.0
b4244000 b4247000 r-xp /usr/lib/libdevice-node.so.0.1
b424f000 b425f000 r-xp /usr/lib/libaccounts-svc.so.0.2.68
b4267000 b426a000 r-xp /usr/lib/libcsc-feature.so.0.0.0
b4272000 b4278000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4280000 b4285000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b428d000 b428e000 r-xp /usr/lib/libcapi-system-power.so.0.1.0
b4297000 b429a000 r-xp /usr/lib/libcapi-system-device.so.0.1.0
b42a2000 b42a7000 r-xp /usr/lib/libcapi-system-runtime-info.so.0.0.3
b42af000 b42b2000 r-xp /usr/lib/libcapi-network-serial.so.0.0.8
b42ba000 b42bb000 r-xp /usr/lib/libcapi-content-mime-type.so.0.0.2
b42c3000 b42d1000 r-xp /usr/lib/libcapi-appfw-application.so.0.1.0
b42da000 b42e0000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.1.0
b42e8000 b430d000 r-xp /usr/lib/libSLP-tapi.so.0.0.0
b4315000 b4318000 r-xp /usr/lib/libuuid.so.1.3.0
b4321000 b4335000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b433d000 b4345000 r-xp /usr/lib/libminizip.so.1.0.0
b434d000 b4359000 r-xp /usr/lib/libmessage-port.so.1.2.2.0
b4362000 b4380000 r-xp /usr/lib/libpcre.so.0.0.1
b4388000 b438c000 r-xp /usr/lib/libheynoti.so.0.0.2
b4394000 b43a2000 r-xp /usr/lib/libdeviced.so.0.1.0
b43ab000 b43b6000 r-xp /usr/lib/libcryptsvc.so.0.0.1
b43c3000 b43cc000 r-xp /usr/lib/libdevman.so.0.1
b43d4000 b43d8000 r-xp /usr/lib/libchromium.so.1.0
b43e0000 b43f1000 r-xp /usr/lib/libprivacy-manager-client.so.0.0.4
b43fa000 b4706000 r-xp /usr/lib/osp/libosp-appfw.so.1.2.2.0
b472e000 b4738000 r-xp /lib/libnss_files-2.13.so
b4741000 b4742000 r-xp /usr/lib/libpmapi.so.1.2
b474a000 b4751000 r-xp /usr/lib/libalarm.so.0.0.0
b4759000 b476c000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b4775000 b4791000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b479a000 b479d000 r-xp /usr/lib/libiniparser.so.0
b47a6000 b47f6000 r-xp /usr/lib/libsoup-2.4.so.1.5.0
b4800000 b4811000 r-xp /usr/lib/libcom-core.so.0.0.1
b4819000 b481f000 r-xp /usr/lib/libappsvc.so.0.1.0
b4827000 b4829000 r-xp /usr/lib/libdri2.so.0.0.0
b4831000 b4839000 r-xp /usr/lib/libdrm.so.2.4.0
b4841000 b4845000 r-xp /usr/lib/libtbm.so.1.0.0
b484d000 b4850000 r-xp /usr/lib/libXv.so.1.0.0
b4858000 b4862000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b486b000 b4937000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b494d000 b495c000 r-xp /usr/lib/libnotification.so.0.1.0
b4964000 b4988000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4991000 b49a1000 r-xp /lib/libresolv-2.13.so
b49a5000 b49a7000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b49af000 b4a87000 r-xp /usr/lib/libxml2.so.2.7.8
b4a94000 b4b71000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b4b7c000 b4b81000 r-xp /usr/lib/libcheck.so.0.0.0
b4b89000 b4b93000 r-xp /usr/lib/libspdy.so.0.0.0
b4b9c000 b4cef000 r-xp /usr/lib/libcrypto.so.1.0.0
b4d0d000 b4d59000 r-xp /usr/lib/libssl.so.1.0.0
b4d65000 b4d93000 r-xp /usr/lib/libidn.so.11.5.44
b4d9c000 b4da6000 r-xp /usr/lib/libcares.so.2.1.0
b4dae000 b4dc5000 r-xp /lib/libexpat.so.1.5.2
b4dcf000 b4df3000 r-xp /usr/lib/libicule.so.48.1
b4dfc000 b4e0a000 r-xp /usr/lib/libsf_common.so
b4e13000 b4eae000 r-xp /usr/lib/libstdc++.so.6.0.14
b4ec1000 b4ed9000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b4eda000 b4edd000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b4ee5000 b4ee9000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b4ef2000 b4ef7000 r-xp /usr/lib/libffi.so.5.0.10
b4eff000 b4f00000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b4f08000 b4f12000 r-xp /usr/lib/libXext.so.6.4.0
b4f1b000 b4f1e000 r-xp /usr/lib/libXtst.so.6.1.0
b4f26000 b4f2c000 r-xp /usr/lib/libXrender.so.1.3.0
b4f34000 b4f3a000 r-xp /usr/lib/libXrandr.so.2.2.0
b4f42000 b4f43000 r-xp /usr/lib/libXinerama.so.1.0.0
b4f4c000 b4f55000 r-xp /usr/lib/libXi.so.6.1.0
b4f5d000 b4f60000 r-xp /usr/lib/libXfixes.so.3.1.0
b4f68000 b4f6a000 r-xp /usr/lib/libXgesture.so.7.0.0
b4f72000 b4f73000 r-xp /usr/lib/libXdamage.so.1.1.0
b4f7c000 b4f83000 r-xp /usr/lib/libXcursor.so.1.0.2
b4f8b000 b4fae000 r-xp /usr/lib/libexif.so.12.3.3
b4fc2000 b4fcc000 r-xp /usr/lib/libethumb.so.1.7.99
b4fd4000 b5018000 r-xp /usr/lib/libsndfile.so.1.0.25
b5026000 b5028000 r-xp /usr/lib/libctxdata.so.0.0.0
b5030000 b503e000 r-xp /usr/lib/libremix.so.0.0.0
b5046000 b5047000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b504f000 b5068000 r-xp /usr/lib/liblua-5.1.so
b5071000 b5078000 r-xp /usr/lib/libembryo.so.1.7.99
b5081000 b50c1000 r-xp /usr/lib/libcurl.so.4.3.0
b50ca000 b5134000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5141000 b5165000 r-xp /usr/lib/libfontconfig.so.1.5.0
b516e000 b51ca000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b51dc000 b51f0000 r-xp /usr/lib/libfribidi.so.0.3.1
b51f8000 b5250000 r-xp /usr/lib/libfreetype.so.6.8.1
b525b000 b527f000 r-xp /usr/lib/libjpeg.so.8.0.2
b5297000 b52ae000 r-xp /lib/libz.so.1.2.5
b52b6000 b52be000 r-xp /usr/lib/libemotion.so.1.7.99
b52c6000 b52cb000 r-xp /usr/lib/libecore_fb.so.1.7.99
b52d4000 b52e2000 r-xp /usr/lib/libsensor.so.1.1.0
b52ee000 b52f4000 r-xp /usr/lib/libappcore-common.so.1.1
b52fc000 b52fe000 r-xp /usr/lib/libpowertop-wrapper.so.0.2.79
b5306000 b5311000 r-xp /usr/lib/libresourced.so.0.2.79
b5319000 b531c000 r-xp /usr/lib/libproc-stat.so.0.2.79
b6319000 b6401000 r-xp /usr/lib/libicuuc.so.48.1
b640e000 b652e000 r-xp /usr/lib/libicui18n.so.48.1
b653c000 b653f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6547000 b654f000 r-xp /usr/lib/libvconf.so.0.2.45
b6557000 b655d000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6565000 b6571000 r-xp /usr/lib/libail.so.0.1.0
b6579000 b6584000 r-xp /usr/lib/libaul.so.0.1.0
b658d000 b65a4000 r-xp /usr/lib/libecore_input.so.1.7.99
b65bf000 b65dc000 r-xp /usr/lib/libecore_evas.so.1.7.99
b65e5000 b65e7000 r-xp /usr/lib/libXcomposite.so.1.0.0
b65ef000 b6623000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b662c000 b665b000 r-xp /usr/lib/libecore_x.so.1.7.99
b6665000 b66a4000 r-xp /usr/lib/libeina.so.1.7.99
b66ad000 b66c2000 r-xp /usr/lib/libecore.so.1.7.99
b66d9000 b66f4000 r-xp /usr/lib/libecore_con.so.1.7.99
b66fd000 b6702000 r-xp /usr/lib/libecore_imf.so.1.7.99
b670a000 b6712000 r-xp /usr/lib/libethumb_client.so.1.7.99
b671a000 b6723000 r-xp /usr/lib/libedbus.so.1.7.99
b672b000 b672d000 r-xp /usr/lib/libefreet_trash.so.1.7.99
b6735000 b6739000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b6742000 b6758000 r-xp /usr/lib/libefreet.so.1.7.99
b6762000 b67be000 r-xp /usr/lib/libedje.so.1.7.99
b67c8000 b6878000 r-xp /usr/lib/libevas.so.1.7.99
b689a000 b68ad000 r-xp /usr/lib/libeet.so.1.7.99
b68b6000 b6920000 r-xp /lib/libm-2.13.so
b6929000 b6931000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.2
b6932000 b6939000 r-xp /usr/lib/libutilX.so.1.1.0
b6941000 b6a63000 r-xp /usr/lib/libelementary.so.1.7.99
b6a78000 b6a7b000 r-xp /lib/libattr.so.1.1.0
b6a83000 b6a85000 r-xp /usr/lib/libXau.so.6.0.0
b6a8d000 b6a93000 r-xp /lib/librt-2.13.so
b6a9c000 b6aa4000 r-xp /lib/libcrypt-2.13.so
b6ad4000 b6ad7000 r-xp /lib/libcap.so.2.21
b6adf000 b6ae1000 r-xp /usr/lib/libiri.so
b6ae9000 b6afe000 r-xp /usr/lib/libxcb.so.1.1.0
b6b06000 b6b11000 r-xp /lib/libunwind.so.8.0.1
b6b3f000 b6c5c000 r-xp /lib/libc-2.13.so
b6c6a000 b6c73000 r-xp /lib/libgcc_s-4.5.3.so.1
b6c7b000 b6ca7000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6cb0000 b6cb3000 r-xp /usr/lib/libbundle.so.0.1.22
b6cbb000 b6cbd000 r-xp /lib/libdl-2.13.so
b6cc6000 b6cc9000 r-xp /usr/lib/libsmack.so.1.0.0
b6cd1000 b6dab000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6db4000 b6dc8000 r-xp /lib/libpthread-2.13.so
b6dd4000 b6dd9000 r-xp /usr/lib/libecore_file.so.1.7.99
b6de1000 b6de9000 r-xp /usr/lib/libappcore-efl.so.1.1
b6deb000 b6dec000 r-xp /usr/lib/libdlog.so.0.0.0
b6df5000 b6e62000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6e6c000 b6e75000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e7d000 b6f63000 r-xp /usr/lib/libX11.so.6.3.0
b6f6e000 b6f6f000 r-xp /usr/local/lib/libcortex-strings.so.1.0.0
b6f77000 b6f7b000 r-xp /usr/lib/libsys-assert.so
b6f83000 b6fa0000 r-xp /lib/ld-2.13.so
bee85000 beea6000 rwxp [stack]
b6f83000 b6fa0000 r-xp /lib/ld-2.13.so
bee85000 beea6000 rwxp [stack]
End of Maps Information

Callstack Information (PID:25351)
Call Stack Count: 47
 0: Tizen::Ui::_ControlImpl::GetFullScreenSizeInfo() + 0x53 (0xb3b8b408) [/usr/lib/osp/libosp-uifw.so] + 0x2ab408
 1: (0xb3d54af7) [/usr/lib/osp/libosp-uifw.so] + 0x474af7
 2: Tizen::Ui::Controls::Panel::SetBackgroundColor(Tizen::Graphics::Color const&) + 0xa (0xb3c32a67) [/usr/lib/osp/libosp-uifw.so] + 0x352a67
 3: MyHondanaSettingForm::SetButton() + 0x9e0 (0xb2ed7148) [/opt/apps/docomo6003/bin/MyHondana.exe] + 0x3e148
 4: MyHondanaSettingForm::OnInitializing() + 0xb0 (0xb2ed5e84) [/opt/apps/docomo6003/bin/MyHondana.exe] + 0x3ce84
 5: Tizen::Ui::_ControlImpl::OnAttachedToMainTree() + 0x22 (0xb3b8bfb7) [/usr/lib/osp/libosp-uifw.so] + 0x2abfb7
 6: Tizen::Ui::Controls::_FormImpl::OnAttachedToMainTree() + 0x28 (0xb3d479ed) [/usr/lib/osp/libosp-uifw.so] + 0x4679ed
 7: Tizen::Ui::_Control::CallOnAttachedToMainTree(Tizen::Ui::_Control&) + 0xb2 (0xb3b74793) [/usr/lib/osp/libosp-uifw.so] + 0x294793
 8: Tizen::Ui::_Control::EndAttaching(Tizen::Ui::_Control&) + 0xec (0xb3b7790d) [/usr/lib/osp/libosp-uifw.so] + 0x29790d
 9: Tizen::Ui::_Control::AttachChild(Tizen::Ui::_Control&) + 0x5a (0xb3b7a2ff) [/usr/lib/osp/libosp-uifw.so] + 0x29a2ff
10: Tizen::Ui::_ContainerImpl::AddChild(Tizen::Ui::_ControlImpl*, bool) + 0xa4 (0xb3b974c1) [/usr/lib/osp/libosp-uifw.so] + 0x2b74c1
11: Tizen::Ui::Container::AddControl(Tizen::Ui::Control*) + 0x26 (0xb3b6eb4f) [/usr/lib/osp/libosp-uifw.so] + 0x28eb4f
12: Tizen::Ui::Container::AddControl(Tizen::Ui::Control const&) + 0x6 (0xb3b6ebdb) [/usr/lib/osp/libosp-uifw.so] + 0x28ebdb
13: (0xb3e10cc7) [/usr/lib/osp/libosp-uifw.so] + 0x530cc7
14: (0xb3e1160f) [/usr/lib/osp/libosp-uifw.so] + 0x53160f
15: (0xb3e1418d) [/usr/lib/osp/libosp-uifw.so] + 0x53418d
16: Tizen::Ui::Scenes::SceneManager::GoForward(Tizen::Ui::Scenes::ForwardSceneTransition const&, Tizen::Base::Collection::IList const*) + 0x18 (0xb3e08c95) [/usr/lib/osp/libosp-uifw.so] + 0x528c95
17: MyHondanaMainForm::OnActionPerformed(Tizen::Ui::Control const&, int) + 0xae4 (0xb2ecab0c) [/opt/apps/docomo6003/bin/MyHondana.exe] + 0x31b0c
18: non-virtual thunk to MyHondanaMainForm::OnActionPerformed(Tizen::Ui::Control const&, int) + 0x3c (0xb2ecac44) [/opt/apps/docomo6003/bin/MyHondana.exe] + 0x31c44
19: (0xb3c3ef2b) [/usr/lib/osp/libosp-uifw.so] + 0x35ef2b
20: Tizen::Base::Runtime::_Event::ProcessListeners(std::tr1::shared_ptr<Tizen::Base::Runtime::IEventArg>) + 0x2bc (0xb454bec1) [/usr/lib/osp/libosp-appfw.so] + 0x151ec1
21: Tizen::Base::Runtime::_Event::Fire(std::tr1::shared_ptr<Tizen::Base::Runtime::IEventArg>) + 0x36 (0xb454c0fb) [/usr/lib/osp/libosp-appfw.so] + 0x1520fb
22: Tizen::Base::Runtime::_Event::Fire(Tizen::Base::Runtime::IEventArg&) + 0x84 (0xb454c1ed) [/usr/lib/osp/libosp-appfw.so] + 0x1521ed
23: (0xb3d3b62f) [/usr/lib/osp/libosp-uifw.so] + 0x45b62f
24: (0xb3c3c7c7) [/usr/lib/osp/libosp-uifw.so] + 0x35c7c7
25: Tizen::Base::Runtime::_Event::ProcessListeners(std::tr1::shared_ptr<Tizen::Base::Runtime::IEventArg>) + 0x2bc (0xb454bec1) [/usr/lib/osp/libosp-appfw.so] + 0x151ec1
26: Tizen::Base::Runtime::_Event::Fire(std::tr1::shared_ptr<Tizen::Base::Runtime::IEventArg>) + 0x36 (0xb454c0fb) [/usr/lib/osp/libosp-appfw.so] + 0x1520fb
27: Tizen::Base::Runtime::_Event::Fire(Tizen::Base::Runtime::IEventArg&) + 0x84 (0xb454c1ed) [/usr/lib/osp/libosp-appfw.so] + 0x1521ed
28: (0xb3c68807) [/usr/lib/osp/libosp-uifw.so] + 0x388807
29: Tizen::Ui::Controls::_ContextMenu::OnTouchReleased(Tizen::Ui::_Control const&, Tizen::Ui::_TouchInfo const&) + 0xe (0xb3c6233b) [/usr/lib/osp/libosp-uifw.so] + 0x38233b
30: Tizen::Ui::_ControlImpl::CallOnTouchReleased(Tizen::Ui::_Control const&, Tizen::Ui::_TouchInfo const&) + 0x21a (0xb3b8da63) [/usr/lib/osp/libosp-uifw.so] + 0x2ada63
31: Tizen::Ui::_ControlImpl::_PropagatedTouchEventListener::OnTouchReleased(Tizen::Ui::_Control const&, Tizen::Ui::_TouchInfo const&) + 0x20c (0xb3b9589d) [/usr/lib/osp/libosp-uifw.so] + 0x2b589d
32: Tizen::Ui::_UiTouchEvent::FireListener(Tizen::Ui::_ITouchEventListener const*, Tizen::Ui::_Control const*, bool, bool&) + 0x1aa (0xb3bed403) [/usr/lib/osp/libosp-uifw.so] + 0x30d403
33: Tizen::Ui::_UiTouchEvent::OnEventProcessing(Tizen::Ui::_Control const&, bool&) + 0x62 (0xb3bed80f) [/usr/lib/osp/libosp-uifw.so] + 0x30d80f
34: Tizen::Ui::_UiEvent::ProcessEvent(Tizen::Ui::_Control const&, bool&) + 0x32 (0xb3be1ee3) [/usr/lib/osp/libosp-uifw.so] + 0x301ee3
35: Tizen::Ui::_UiEventManager::ProcessBubblingEvent(Tizen::Base::Collection::LinkedListT<Tizen::Base::_HandleT<Tizen::Ui::_Control> > const&, Tizen::Ui::_UiEvent const&, bool&) + 0x6c (0xb3be27b1) [/usr/lib/osp/libosp-uifw.so] + 0x3027b1
36: Tizen::Ui::_UiEventManager::ProcessEvent(Tizen::Ui::_UiEvent const&, bool&) + 0x1ec (0xb3be2a09) [/usr/lib/osp/libosp-uifw.so] + 0x302a09
37: Tizen::Ui::_UiEventManager::Fire(Tizen::Ui::_UiEvent const&) + 0x8a (0xb3be2aeb) [/usr/lib/osp/libosp-uifw.so] + 0x302aeb
38: Tizen::Ui::_UiEventManager::SendEvent(Tizen::Ui::_UiEvent const&) + 0x6 (0xb3be2b7b) [/usr/lib/osp/libosp-uifw.so] + 0x302b7b
39: (0xb3bd2c7f) [/usr/lib/osp/libosp-uifw.so] + 0x2f2c7f
40: (0xb3bd630f) [/usr/lib/osp/libosp-uifw.so] + 0x2f630f
41: (0xb66b4aad) [/usr/lib/libecore.so.1] + 0x7aad
42: (0xb66b8153) [/usr/lib/libecore.so.1] + 0xb153
43: ecore_main_loop_begin + 0x30 (0xb66b8575) [/usr/lib/libecore.so.1] + 0xb575
44: elm_run + 0x6 (0xb69eac73) [/usr/lib/libelementary.so.1] + 0xa9c73
45: appcore_efl_main + 0x114 (0xb6de7268) [/usr/lib/libappcore-efl.so.1] + 0x6268
46: app_efl_main + 0xc6 (0xb42cced3) [/usr/lib/libcapi-appfw-application.so.0] + 0x9ed3
End of Call Stack

Package Information
Package Name: docomo6003.MyHondana
Package ID : docomo6003
Version: 1.0.0
Package Type: tpk
App Name: d book MyShelf
App ID: docomo6003.MyHondana
Type: Application
Categories: (NULL)
