namespace generators {
    
    
    public class locations_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar4 = default(System.Boolean); //IsContext = False IsNew = False
			Space StoredVariable0 = ((Space)root.GetComponent(typeof(Space))); //IsContext = False IsNew = False
			if(StoredVariable0 != null)
			{
				System.Boolean ifResult1; //IsContext = False IsNew = False
				
				System.Collections.Generic.List<Place> OperandVar3 = default(System.Collections.Generic.List<Place>); //IsContext = False IsNew = False
				System.Collections.Generic.List<Place> prop2 = StoredVariable0.Places; //IsContext = False IsNew = False
				if(prop2 != null)
				{
					OperandVar3 = prop2;
				}
				
				
				if(ifResult1 = ( ( (OperandVar3 != null ? OperandVar3.Count : 0))) == ( ( (0f))))
				{
					applicable = true;
					OperandVar4 = applicable;
				}
			}
			return (System.Boolean) (OperandVar4);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Space subContext5 = (Space)root.GetComponent(typeof(Space)); //IsContext = True IsNew = False
				//ContextStatement Space subContext5 ContextSwitchInterpreter
				if(subContext5 != null)
				{
					
					subContext5.Size = (System.Int32)( (5f));
					System.Single OperandVar7 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop6 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar7 = prop6;
					for (int i = 0; i <  (OperandVar7); i++)
					{
						UnityEngine.GameObject loc = new UnityEngine.GameObject("loc"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject loc8 = loc; //IsContext = True IsNew = False
							Entity AddContext9 = (Entity)loc.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Entity AddContext9 ContextSwitchInterpreter
								if(AddContext9 != null)
								{
									GODelegate Lambda10 = (UnityEngine.GameObject entity) => 
									{
										
										
										{
											//ContextStatement UnityEngine.GameObject entity ContextSwitchInterpreter
											if(entity != null)
											{
												
												{
													SpaceMarker subContext11 = (SpaceMarker)entity.GetComponent(typeof(SpaceMarker)); //IsContext = True IsNew = False
													//ContextStatement SpaceMarker subContext11 ContextSwitchInterpreter
													if(subContext11 != null)
													{
														
														{
															Space subContext12 = subContext11.CurrentSpace; //IsContext = True IsNew = False
															//ContextStatement Space subContext12 ContextPropertySwitchInterpreter
															if(subContext12 != null)
															{
																Place OperandVar14 = default(Place); //IsContext = False IsNew = False
																Place StoredVariable13 = ((Place)subContext12.GetComponent(typeof(Place))); //IsContext = False IsNew = False
																if(StoredVariable13 != null)
																{
																	OperandVar14 = StoredVariable13;
																}
																subContext12.Detach((Place)( (OperandVar14)));
															}
														}
													}
												}
											}
										}
									};
									AddContext9.OnDestruction(Lambda10);
								}
							}
							Place AddContext15 = (Place)loc.AddComponent(typeof(Place)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Place AddContext15 ContextSwitchInterpreter
								if(AddContext15 != null)
								{
									System.Single OperandVar17 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop16 = External.Random( (1f), (3f)); //IsContext = False IsNew = False
									OperandVar17 = prop16;
									AddContext15.Size = (System.Int32)( (OperandVar17));
								}
							}
							Named AddContext18 = (Named)loc.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext18 ContextSwitchInterpreter
								if(AddContext18 != null)
								{
									
									
									
									AddContext18.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Location of: ")).ToString());
									
									
									System.String OperandVar20 = default(System.String); //IsContext = False IsNew = False
									System.String prop19 = External.RandomName(); //IsContext = False IsNew = False
									if(prop19 != null)
									{
										OperandVar20 = prop19;
									}
									AddContext18.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar20)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(loc);
						Place OperandVar22 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable21 = ((Place)loc.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable21 != null)
						{
							OperandVar22 = StoredVariable21;
						}
						subContext5.Attach((Place)( (OperandVar22)));
					}
				}
			}
		}
        }
    }
    
    public class named_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar36 = default(System.Boolean); //IsContext = False IsNew = False
			UiObject StoredVariable23 = ((UiObject)root.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
			if(StoredVariable23 != null)
			{
				System.Boolean ifResult24; //IsContext = False IsNew = False
				
				System.Boolean OperandVar31 = default(System.Boolean); //IsContext = False IsNew = False
				UnityEngine.GameObject prop25 = StoredVariable23.ShowedObject; //IsContext = False IsNew = False
				if(prop25 != null)
				{
					System.Boolean ifResult26; //IsContext = False IsNew = False
					System.Boolean OperandVar30 = default(System.Boolean); //IsContext = False IsNew = False
					Named OperandVar28 = default(Named); //IsContext = False IsNew = False
					Named StoredVariable27 = ((Named)prop25.GetComponent(typeof(Named))); //IsContext = False IsNew = False
					if(StoredVariable27 != null)
					{
						OperandVar28 = StoredVariable27;
					}
					System.Boolean prop29 = External.Has( (OperandVar28)); //IsContext = False IsNew = False
					OperandVar30 = prop29;
					if(ifResult26 =  (OperandVar30))
					{
						OperandVar31 = ifResult26;
					}
				}
				
				System.Boolean OperandVar35 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.named_ui_marker OperandVar33 = default(Blackboards.named_ui_marker); //IsContext = False IsNew = False
				Blackboards.named_ui_marker StoredVariable32 = ((Blackboards.named_ui_marker)StoredVariable23.GetComponent(typeof(Blackboards.named_ui_marker))); //IsContext = False IsNew = False
				if(StoredVariable32 != null)
				{
					OperandVar33 = StoredVariable32;
				}
				System.Boolean prop34 = External.Has( (OperandVar33)); //IsContext = False IsNew = False
				OperandVar35 = prop34;
				if(ifResult24 = ( ( (OperandVar31))) && ( (!(OperandVar35))))
				{
					applicable = true;
					OperandVar36 = applicable;
				}
			}
			return (System.Boolean) (OperandVar36);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.named_ui_marker>();
			
			{
				UiObject subContext37 = (UiObject)root.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
				//ContextStatement UiObject subContext37 ContextSwitchInterpreter
				if(subContext37 != null)
				{
					Named OperandVar40 = default(Named); //IsContext = False IsNew = False
					UnityEngine.GameObject prop38 = subContext37.ShowedObject; //IsContext = False IsNew = False
					if(prop38 != null)
					{
						Named StoredVariable39 = ((Named)prop38.GetComponent(typeof(Named))); //IsContext = False IsNew = False
						if(StoredVariable39 != null)
						{
							OperandVar40 = StoredVariable39;
						}
					}
					Named showed_named =  (OperandVar40); //IsContext = False IsNew = False
					TextField ContextVar41 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar41 ContextSwitchInterpreter
						if(ContextVar41 != null)
						{
							System.String OperandVar43 = default(System.String); //IsContext = False IsNew = False
							System.String prop42 = showed_named.FullName; //IsContext = False IsNew = False
							if(prop42 != null)
							{
								OperandVar43 = prop42;
							}
							ContextVar41.Show(( (OperandVar43)).ToString());
							
							{
								//ContextStatement Named showed_named ContextSwitchInterpreter
								if(showed_named != null)
								{
									VoidDelegate Lambda44 = () => 
									{
										System.String OperandVar46 = default(System.String); //IsContext = False IsNew = False
										System.String prop45 = showed_named.FullName; //IsContext = False IsNew = False
										if(prop45 != null)
										{
											OperandVar46 = prop45;
										}
										ContextVar41.Show(( (OperandVar46)).ToString());
									};
									showed_named.OnUpdate(Lambda44);
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext47 = ContextVar41.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext47 ContextPropertySwitchInterpreter
								if(subContext47 != null)
								{
									
									subContext47.minHeight = (System.Single)( (20f));
								}
							}
						}
					}
				}
			}
		}
        }
    }
    
    public class place_ui : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar61 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable48 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable48 != null)
			{
				UiObject StoredVariable49 = ((UiObject)StoredVariable48.GetComponent(typeof(UiObject))); //IsContext = False IsNew = False
				if(StoredVariable49 != null)
				{
					System.Boolean ifResult50; //IsContext = False IsNew = False
					
					System.Boolean OperandVar57 = default(System.Boolean); //IsContext = False IsNew = False
					UnityEngine.GameObject prop51 = StoredVariable49.ShowedObject; //IsContext = False IsNew = False
					if(prop51 != null)
					{
						System.Boolean ifResult52; //IsContext = False IsNew = False
						System.Boolean OperandVar56 = default(System.Boolean); //IsContext = False IsNew = False
						Place OperandVar54 = default(Place); //IsContext = False IsNew = False
						Place StoredVariable53 = ((Place)prop51.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable53 != null)
						{
							OperandVar54 = StoredVariable53;
						}
						System.Boolean prop55 = External.Has( (OperandVar54)); //IsContext = False IsNew = False
						OperandVar56 = prop55;
						if(ifResult52 =  (OperandVar56))
						{
							OperandVar57 = ifResult52;
						}
					}
					
					System.Boolean OperandVar60 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar58 = default(System.String); //IsContext = False IsNew = False
					OperandVar58 = "place_ui_set";
					System.Boolean prop59 = StoredVariable48.HasMarker( (OperandVar58)); //IsContext = False IsNew = False
					OperandVar60 = prop59;
					if(ifResult50 = ( ( (OperandVar57))) && ( (!(OperandVar60))))
					{
						applicable = true;
						OperandVar61 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar61);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext62 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext62 ContextSwitchInterpreter
				if(subContext62 != null)
				{
					System.String OperandVar63 = default(System.String); //IsContext = False IsNew = False
					OperandVar63 = "place_ui_set";
					subContext62.SetMarker(( (OperandVar63)).ToString());
				}
			}
			
			{
				UiObject subContext64 = (UiObject)root.GetComponent(typeof(UiObject)); //IsContext = True IsNew = False
				//ContextStatement UiObject subContext64 ContextSwitchInterpreter
				if(subContext64 != null)
				{
					Place OperandVar67 = default(Place); //IsContext = False IsNew = False
					UnityEngine.GameObject prop65 = subContext64.ShowedObject; //IsContext = False IsNew = False
					if(prop65 != null)
					{
						Place StoredVariable66 = ((Place)prop65.GetComponent(typeof(Place))); //IsContext = False IsNew = False
						if(StoredVariable66 != null)
						{
							OperandVar67 = StoredVariable66;
						}
					}
					Place pl =  (OperandVar67); //IsContext = False IsNew = False
					Blackboards.place_ui_data puidata = root.AddComponent<Blackboards.place_ui_data>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement Blackboards.place_ui_data puidata ContextSwitchInterpreter
						if(puidata != null)
						{
							System.Int32 OperandVar69 = default(System.Int32); //IsContext = False IsNew = False
							System.Int32 prop68 = pl.Size; //IsContext = False IsNew = False
							OperandVar69 = prop68;
							puidata.LastSize = (System.Int32)( (OperandVar69));
						}
					}
					TextField ContextVar70 = root.AddComponent<TextField>();; //IsContext = False IsNew = True
					
					{
						//ContextStatement TextField ContextVar70 ContextSwitchInterpreter
						if(ContextVar70 != null)
						{
							System.Int32 OperandVar72 = default(System.Int32); //IsContext = False IsNew = False
							System.Int32 prop71 = pl.Size; //IsContext = False IsNew = False
							OperandVar72 = prop71;
							ContextVar70.Show(( (OperandVar72)).ToString());
							System.Boolean OperandVar76 = default(System.Boolean); //IsContext = False IsNew = False
							Updated OperandVar74 = default(Updated); //IsContext = False IsNew = False
							Updated StoredVariable73 = ((Updated)ContextVar70.GetComponent(typeof(Updated))); //IsContext = False IsNew = False
							if(StoredVariable73 != null)
							{
								OperandVar74 = StoredVariable73;
							}
							System.Boolean prop75 = External.Has( (OperandVar74)); //IsContext = False IsNew = False
							OperandVar76 = prop75;
							if(!(OperandVar76))
							{
								root.AddComponent<Updated>();
							}
							
							{
								//ContextStatement TextField ContextVar70 ContextSwitchInterpreter
								if(ContextVar70 != null)
								{
									
									ContextVar70.Label = (System.String)( ("size"));
								}
							}
							
							{
								UnityEngine.UI.LayoutElement subContext77 = ContextVar70.Layout; //IsContext = True IsNew = False
								//ContextStatement UnityEngine.UI.LayoutElement subContext77 ContextPropertySwitchInterpreter
								if(subContext77 != null)
								{
									
									subContext77.minHeight = (System.Single)( (20f));
								}
							}
							
							{
								Updated subContext78 = (Updated)root.GetComponent(typeof(Updated)); //IsContext = True IsNew = False
								//ContextStatement Updated subContext78 ContextSwitchInterpreter
								if(subContext78 != null)
								{
									BoolDelegate Lambda79 = () => 
									{
										System.Boolean return_value = default(System.Boolean); //IsContext = False IsNew = False
										
										{
											//ContextStatement Place pl ContextSwitchInterpreter
											if(pl != null)
											{
												
												{
													//ContextStatement Blackboards.place_ui_data puidata ContextSwitchInterpreter
													if(puidata != null)
													{
														
														
														System.Int32 OperandVar81 = default(System.Int32); //IsContext = False IsNew = False
														if(pl != null)
														{
															System.Int32 prop80 = pl.Size; //IsContext = False IsNew = False
															OperandVar81 = prop80;
														}
														
														System.Int32 OperandVar83 = default(System.Int32); //IsContext = False IsNew = False
														if(puidata != null)
														{
															System.Int32 prop82 = puidata.LastSize; //IsContext = False IsNew = False
															OperandVar83 = prop82;
														}
														if(!(( ( (OperandVar81))) == ( ( (OperandVar83)))))
														{
															System.Int32 OperandVar85 = default(System.Int32); //IsContext = False IsNew = False
															if(pl != null)
															{
																System.Int32 prop84 = pl.Size; //IsContext = False IsNew = False
																OperandVar85 = prop84;
															}
															puidata.LastSize = (System.Int32)( (OperandVar85));
															System.Int32 OperandVar87 = default(System.Int32); //IsContext = False IsNew = False
															if(pl != null)
															{
																System.Int32 prop86 = pl.Size; //IsContext = False IsNew = False
																OperandVar87 = prop86;
															}
															ContextVar70.Show(( (OperandVar87)).ToString());
														}
													}
												}
											}
										}
										return return_value;
									};
									subContext78.OnUpdate(Lambda79);
								}
							}
						}
					}
				}
			}
		}
        }
    }
    
    public class agents_pool_filler : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar96 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable88 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable88 != null)
			{
				Place StoredVariable89 = ((Place)StoredVariable88.GetComponent(typeof(Place))); //IsContext = False IsNew = False
				if(StoredVariable89 != null)
				{
					System.Boolean ifResult90; //IsContext = False IsNew = False
					
					
					System.Collections.Generic.List<Agent> OperandVar92 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
					System.Collections.Generic.List<Agent> prop91 = StoredVariable89.Agents; //IsContext = False IsNew = False
					if(prop91 != null)
					{
						OperandVar92 = prop91;
					}
					
					
					
					System.Boolean OperandVar95 = default(System.Boolean); //IsContext = False IsNew = False
					System.String OperandVar93 = default(System.String); //IsContext = False IsNew = False
					OperandVar93 = "agents_pool";
					System.Boolean prop94 = StoredVariable88.HasMarker( (OperandVar93)); //IsContext = False IsNew = False
					OperandVar95 = prop94;
					if(ifResult90 = ( (( ( (OperandVar92 != null ? OperandVar92.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar95))))
					{
						applicable = true;
						OperandVar96 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar96);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Place subContext97 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext97 ContextSwitchInterpreter
				if(subContext97 != null)
				{
					
					subContext97.Size = (System.Int32)( (5f));
					System.Single OperandVar99 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop98 = External.Random( (1f), (4f)); //IsContext = False IsNew = False
					OperandVar99 = prop98;
					for (int i = 0; i <  (OperandVar99); i++)
					{
						UnityEngine.GameObject ag = new UnityEngine.GameObject("ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject ag100 = ag; //IsContext = True IsNew = False
							Entity AddContext101 = (Entity)ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Entity AddContext101 ContextSwitchInterpreter
								if(AddContext101 != null)
								{
									GODelegate Lambda102 = (UnityEngine.GameObject entity) => 
									{
										
										
										{
											//ContextStatement UnityEngine.GameObject entity ContextSwitchInterpreter
											if(entity != null)
											{
												
												{
													PlaceMarker subContext103 = (PlaceMarker)entity.GetComponent(typeof(PlaceMarker)); //IsContext = True IsNew = False
													//ContextStatement PlaceMarker subContext103 ContextSwitchInterpreter
													if(subContext103 != null)
													{
														
														{
															Place subContext104 = subContext103.CurrentPlace; //IsContext = True IsNew = False
															//ContextStatement Place subContext104 ContextPropertySwitchInterpreter
															if(subContext104 != null)
															{
																Agent OperandVar106 = default(Agent); //IsContext = False IsNew = False
																Agent StoredVariable105 = ((Agent)subContext104.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
																if(StoredVariable105 != null)
																{
																	OperandVar106 = StoredVariable105;
																}
																subContext104.Detach((Agent)( (OperandVar106)));
															}
														}
													}
												}
											}
										}
									};
									AddContext101.OnDestruction(Lambda102);
								}
							}
							Agent AddContext107 = (Agent)ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.human AddContext108 = (Blackboards.human)ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext108 ContextSwitchInterpreter
								if(AddContext108 != null)
								{
									System.Single OperandVar110 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop109 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar110 = prop109;
									AddContext108.Age = (System.Int32)( (OperandVar110));
								}
							}
							Named AddContext111 = (Named)ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext111 ContextSwitchInterpreter
								if(AddContext111 != null)
								{
									
									
									
									AddContext111.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Agent: ")).ToString());
									
									
									System.String OperandVar113 = default(System.String); //IsContext = False IsNew = False
									System.String prop112 = External.RandomName(); //IsContext = False IsNew = False
									if(prop112 != null)
									{
										OperandVar113 = prop112;
									}
									AddContext111.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar113)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(ag);
						Agent OperandVar115 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable114 = ((Agent)ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable114 != null)
						{
							OperandVar115 = StoredVariable114;
						}
						subContext97.Attach((Agent)( (OperandVar115)));
					}
				}
			}
		}
        }
    }
    
    public class location_event : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar122 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable116 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable116 != null)
			{
				System.Boolean ifResult117; //IsContext = False IsNew = False
				System.Boolean OperandVar121 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.event_marker OperandVar119 = default(Blackboards.event_marker); //IsContext = False IsNew = False
				Blackboards.event_marker StoredVariable118 = ((Blackboards.event_marker)StoredVariable116.GetComponent(typeof(Blackboards.event_marker))); //IsContext = False IsNew = False
				if(StoredVariable118 != null)
				{
					OperandVar119 = StoredVariable118;
				}
				System.Boolean prop120 = External.Has( (OperandVar119)); //IsContext = False IsNew = False
				OperandVar121 = prop120;
				if(ifResult117 = !(OperandVar121))
				{
					applicable = true;
					OperandVar122 = applicable;
				}
			}
			return (System.Boolean) (OperandVar122);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.event_marker>();
		}
        }
    }
    
    public class agent_personality : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar129 = default(System.Boolean); //IsContext = False IsNew = False
			Agent StoredVariable123 = ((Agent)root.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
			if(StoredVariable123 != null)
			{
				System.Boolean ifResult124; //IsContext = False IsNew = False
				System.Boolean OperandVar128 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.personality OperandVar126 = default(Blackboards.personality); //IsContext = False IsNew = False
				Blackboards.personality StoredVariable125 = ((Blackboards.personality)StoredVariable123.GetComponent(typeof(Blackboards.personality))); //IsContext = False IsNew = False
				if(StoredVariable125 != null)
				{
					OperandVar126 = StoredVariable125;
				}
				System.Boolean prop127 = External.Has( (OperandVar126)); //IsContext = False IsNew = False
				OperandVar128 = prop127;
				if(ifResult124 = !(OperandVar128))
				{
					applicable = true;
					OperandVar129 = applicable;
				}
			}
			return (System.Boolean) (OperandVar129);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.personality>();
		}
        }
    }
    
    public class aged_generation_add : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar136 = default(System.Boolean); //IsContext = False IsNew = False
			Blackboards.human StoredVariable130 = ((Blackboards.human)root.GetComponent(typeof(Blackboards.human))); //IsContext = False IsNew = False
			if(StoredVariable130 != null)
			{
				System.Boolean ifResult131; //IsContext = False IsNew = False
				System.Boolean OperandVar135 = default(System.Boolean); //IsContext = False IsNew = False
				Blackboards.aged_generation OperandVar133 = default(Blackboards.aged_generation); //IsContext = False IsNew = False
				Blackboards.aged_generation StoredVariable132 = ((Blackboards.aged_generation)StoredVariable130.GetComponent(typeof(Blackboards.aged_generation))); //IsContext = False IsNew = False
				if(StoredVariable132 != null)
				{
					OperandVar133 = StoredVariable132;
				}
				System.Boolean prop134 = External.Has( (OperandVar133)); //IsContext = False IsNew = False
				OperandVar135 = prop134;
				if(ifResult131 = !(OperandVar135))
				{
					applicable = true;
					OperandVar136 = applicable;
				}
			}
			return (System.Boolean) (OperandVar136);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			root.AddComponent<Blackboards.aged_generation>();
		}
        }
    }
    
    public class historical_persons : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar146 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable137 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable137 != null)
			{
				Lore StoredVariable138 = ((Lore)StoredVariable137.GetComponent(typeof(Lore))); //IsContext = False IsNew = False
				if(StoredVariable138 != null)
				{
					Place StoredVariable139 = ((Place)StoredVariable138.GetComponent(typeof(Place))); //IsContext = False IsNew = False
					if(StoredVariable139 != null)
					{
						System.Boolean ifResult140; //IsContext = False IsNew = False
						
						
						System.Collections.Generic.List<Agent> OperandVar142 = default(System.Collections.Generic.List<Agent>); //IsContext = False IsNew = False
						System.Collections.Generic.List<Agent> prop141 = StoredVariable139.Agents; //IsContext = False IsNew = False
						if(prop141 != null)
						{
							OperandVar142 = prop141;
						}
						
						
						
						System.Boolean OperandVar145 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar143 = default(System.String); //IsContext = False IsNew = False
						OperandVar143 = "lore_pool";
						System.Boolean prop144 = StoredVariable137.HasMarker( (OperandVar143)); //IsContext = False IsNew = False
						OperandVar145 = prop144;
						if(ifResult140 = ( (( ( (OperandVar142 != null ? OperandVar142.Count : 0))) == ( ( (0f))))) && ( ( (OperandVar145))))
						{
							applicable = true;
							OperandVar146 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar146);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Place subContext147 = (Place)root.GetComponent(typeof(Place)); //IsContext = True IsNew = False
				//ContextStatement Place subContext147 ContextSwitchInterpreter
				if(subContext147 != null)
				{
					
					subContext147.Size = (System.Int32)( (10f));
					System.Single OperandVar149 = default(System.Single); //IsContext = False IsNew = False
					
					
					System.Single prop148 = External.Random( (4f), (10f)); //IsContext = False IsNew = False
					OperandVar149 = prop148;
					for (int i = 0; i <  (OperandVar149); i++)
					{
						UnityEngine.GameObject old_ag = new UnityEngine.GameObject("old_ag"); //IsContext = False IsNew = False
						
						{
							UnityEngine.GameObject old_ag150 = old_ag; //IsContext = True IsNew = False
							Entity AddContext151 = (Entity)old_ag.AddComponent(typeof(Entity)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Entity AddContext151 ContextSwitchInterpreter
								if(AddContext151 != null)
								{
									GODelegate Lambda152 = (UnityEngine.GameObject entity) => 
									{
										
										
										External.Log((System.Object)( ("detaching")));
										
										{
											//ContextStatement UnityEngine.GameObject entity ContextSwitchInterpreter
											if(entity != null)
											{
												Agent OperandVar154 = default(Agent); //IsContext = False IsNew = False
												Agent StoredVariable153 = ((Agent)entity.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
												if(StoredVariable153 != null)
												{
													OperandVar154 = StoredVariable153;
												}
												Agent e_agent =  (OperandVar154); //IsContext = False IsNew = False
												
												{
													PlaceMarker subContext155 = (PlaceMarker)entity.GetComponent(typeof(PlaceMarker)); //IsContext = True IsNew = False
													//ContextStatement PlaceMarker subContext155 ContextSwitchInterpreter
													if(subContext155 != null)
													{
														
														{
															Place subContext156 = subContext155.CurrentPlace; //IsContext = True IsNew = False
															//ContextStatement Place subContext156 ContextPropertySwitchInterpreter
															if(subContext156 != null)
															{
																Agent OperandVar157 = default(Agent); //IsContext = False IsNew = False
																OperandVar157 = e_agent;
																subContext156.Detach((Agent)( (OperandVar157)));
															}
														}
													}
												}
											}
										}
									};
									AddContext151.OnDestruction(Lambda152);
								}
							}
							Agent AddContext158 = (Agent)old_ag.AddComponent(typeof(Agent)); //IsContext = True IsNew = True
							Blackboards.historical_person AddContext159 = (Blackboards.historical_person)old_ag.AddComponent(typeof(Blackboards.historical_person)); //IsContext = True IsNew = True
							Blackboards.human AddContext160 = (Blackboards.human)old_ag.AddComponent(typeof(Blackboards.human)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Blackboards.human AddContext160 ContextSwitchInterpreter
								if(AddContext160 != null)
								{
									System.Single OperandVar162 = default(System.Single); //IsContext = False IsNew = False
									
									
									System.Single prop161 = External.Random( (20f), (45f)); //IsContext = False IsNew = False
									OperandVar162 = prop161;
									AddContext160.Age = (System.Int32)( (OperandVar162));
								}
							}
							Named AddContext163 = (Named)old_ag.AddComponent(typeof(Named)); //IsContext = True IsNew = True
							
							{
								//ContextStatement Named AddContext163 ContextSwitchInterpreter
								if(AddContext163 != null)
								{
									
									
									
									AddContext163.Set(( ("prefix")).ToString(),(System.Single)( (0f)),( ("Historical person: ")).ToString());
									
									
									System.String OperandVar165 = default(System.String); //IsContext = False IsNew = False
									System.String prop164 = External.RandomName(); //IsContext = False IsNew = False
									if(prop164 != null)
									{
										OperandVar165 = prop164;
									}
									AddContext163.Set(( ("main_name")).ToString(),(System.Single)( (1f)),( (OperandVar165)).ToString());
								}
							}
						}
						UnityEngine.Object.FindObjectOfType<Generators>().Generate(old_ag);
						Agent OperandVar167 = default(Agent); //IsContext = False IsNew = False
						Agent StoredVariable166 = ((Agent)old_ag.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable166 != null)
						{
							OperandVar167 = StoredVariable166;
						}
						subContext147.Attach((Agent)( (OperandVar167)));
					}
				}
			}
		}
        }
    }
    
    public class change_name_historical_action : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar177 = default(System.Boolean); //IsContext = False IsNew = False
			Entity StoredVariable168 = ((Entity)root.GetComponent(typeof(Entity))); //IsContext = False IsNew = False
			if(StoredVariable168 != null)
			{
				Blackboards.historical_person StoredVariable169 = ((Blackboards.historical_person)StoredVariable168.GetComponent(typeof(Blackboards.historical_person))); //IsContext = False IsNew = False
				if(StoredVariable169 != null)
				{
					Named StoredVariable170 = ((Named)StoredVariable169.GetComponent(typeof(Named))); //IsContext = False IsNew = False
					if(StoredVariable170 != null)
					{
						Agent StoredVariable171 = ((Agent)StoredVariable170.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
						if(StoredVariable171 != null)
						{
							System.Boolean ifResult172; //IsContext = False IsNew = False
							
							
							System.Boolean OperandVar174 = default(System.Boolean); //IsContext = False IsNew = False
							System.Boolean prop173 = StoredVariable171.Act; //IsContext = False IsNew = False
							OperandVar174 = prop173;
							
							
							
							System.Boolean OperandVar176 = default(System.Boolean); //IsContext = False IsNew = False
							if(StoredVariable168 != null)
							{
								System.Boolean prop175 = StoredVariable168.Dead; //IsContext = False IsNew = False
								OperandVar176 = prop175;
							}
							if(ifResult172 = ( (( ( (OperandVar174))) == ( ( (true))))) && ( (!(OperandVar176))))
							{
								applicable = true;
								OperandVar177 = applicable;
							}
						}
					}
				}
			}
			return (System.Boolean) (OperandVar177);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.5f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Named subContext178 = (Named)root.GetComponent(typeof(Named)); //IsContext = True IsNew = False
				//ContextStatement Named subContext178 ContextSwitchInterpreter
				if(subContext178 != null)
				{
					
					System.String OperandVar180 = default(System.String); //IsContext = False IsNew = False
					System.String prop179 = External.RandomName(); //IsContext = False IsNew = False
					if(prop179 != null)
					{
						OperandVar180 = prop179;
					}
					subContext178.Switch(( ("main_name")).ToString(),( (OperandVar180)).ToString());
				}
			}
		}
        }
    }
    
    public class location_log : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar186 = default(System.Boolean); //IsContext = False IsNew = False
			Place StoredVariable181 = ((Place)root.GetComponent(typeof(Place))); //IsContext = False IsNew = False
			if(StoredVariable181 != null)
			{
				Named StoredVariable182 = ((Named)StoredVariable181.GetComponent(typeof(Named))); //IsContext = False IsNew = False
				if(StoredVariable182 != null)
				{
					System.Boolean ifResult183; //IsContext = False IsNew = False
					
					System.Boolean OperandVar185 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable181 != null)
					{
						System.Boolean prop184 = StoredVariable181.Act; //IsContext = False IsNew = False
						OperandVar185 = prop184;
					}
					
					
					if(ifResult183 = ( ( (OperandVar185))) == ( ( (true))))
					{
						applicable = true;
						OperandVar186 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar186);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (0.3f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			System.String OperandVar190 = default(System.String); //IsContext = False IsNew = False
			Named StoredVariable187 = ((Named)root.GetComponent(typeof(Named))); //IsContext = False IsNew = False
			if(StoredVariable187 != null)
			{
				System.String OperandVar188 = default(System.String); //IsContext = False IsNew = False
				OperandVar188 = "main_name";
				System.String prop189 = StoredVariable187.Get( (OperandVar188)); //IsContext = False IsNew = False
				if(prop189 != null)
				{
					OperandVar190 = prop189;
				}
			}
			External.Log((System.Object)( (OperandVar190)));
		}
        }
    }
    
    public class destroy_self : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar198 = default(System.Boolean); //IsContext = False IsNew = False
			Entity StoredVariable191 = ((Entity)root.GetComponent(typeof(Entity))); //IsContext = False IsNew = False
			if(StoredVariable191 != null)
			{
				Agent StoredVariable192 = ((Agent)StoredVariable191.GetComponent(typeof(Agent))); //IsContext = False IsNew = False
				if(StoredVariable192 != null)
				{
					System.Boolean ifResult193; //IsContext = False IsNew = False
					
					
					System.Boolean OperandVar195 = default(System.Boolean); //IsContext = False IsNew = False
					System.Boolean prop194 = StoredVariable192.Act; //IsContext = False IsNew = False
					OperandVar195 = prop194;
					
					
					
					System.Boolean OperandVar197 = default(System.Boolean); //IsContext = False IsNew = False
					if(StoredVariable191 != null)
					{
						System.Boolean prop196 = StoredVariable191.Dead; //IsContext = False IsNew = False
						OperandVar197 = prop196;
					}
					if(ifResult193 = ( (( ( (OperandVar195))) == ( ( (true))))) && ( (!(OperandVar197))))
					{
						applicable = true;
						OperandVar198 = applicable;
					}
				}
			}
			return (System.Boolean) (OperandVar198);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1E-05f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			
			
			UnityEngine.GameObject OperandVar199 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar199 = root;
			External.Log((System.Object)(( ( ("Destroying self "))) + ( ( (OperandVar199)))));
			UnityEngine.GameObject OperandVar200 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
			OperandVar200 = root;
			External.Destroy((UnityEngine.Object)( (OperandVar200)));
		}
        }
    }
    
    public class story_start : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar209 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable201 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable201 != null)
			{
				System.Boolean ifResult202; //IsContext = False IsNew = False
				
				System.Boolean OperandVar205 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar203 = default(System.String); //IsContext = False IsNew = False
				OperandVar203 = "init_node";
				System.Boolean prop204 = StoredVariable201.HasMarker( (OperandVar203)); //IsContext = False IsNew = False
				OperandVar205 = prop204;
				
				System.Boolean OperandVar208 = default(System.Boolean); //IsContext = False IsNew = False
				System.String OperandVar206 = default(System.String); //IsContext = False IsNew = False
				OperandVar206 = "story_set";
				System.Boolean prop207 = StoredVariable201.HasMarker( (OperandVar206)); //IsContext = False IsNew = False
				OperandVar208 = prop207;
				if(ifResult202 = ( ( (OperandVar205))) && ( (!(OperandVar208))))
				{
					applicable = true;
					OperandVar209 = applicable;
				}
			}
			return (System.Boolean) (OperandVar209);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext210 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext210 ContextSwitchInterpreter
				if(subContext210 != null)
				{
					System.String OperandVar211 = default(System.String); //IsContext = False IsNew = False
					OperandVar211 = "story_set";
					subContext210.SetMarker(( (OperandVar211)).ToString());
				}
			}
			UnityEngine.GameObject s_node = new UnityEngine.GameObject("s_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject s_node212 = s_node; //IsContext = True IsNew = False
				TaleNode AddContext213 = (TaleNode)s_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.story_node AddContext214 = (Blackboards.story_node)s_node.AddComponent(typeof(Blackboards.story_node)); //IsContext = True IsNew = True
				Markers AddContext215 = (Markers)s_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(s_node);
			
			{
				UnityEngine.GameObject subContext216 = s_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext216 ContextPropertySwitchInterpreter
				if(subContext216 != null)
				{
					
					{
						TaleNode subContext217 = (TaleNode)subContext216.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext217 ContextSwitchInterpreter
						if(subContext217 != null)
						{
							
							subContext217.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
		}
        }
    }
    
    public class story_basic_decomposition : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar227 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable218 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable218 != null)
			{
				Blackboards.story_node StoredVariable219 = ((Blackboards.story_node)StoredVariable218.GetComponent(typeof(Blackboards.story_node))); //IsContext = False IsNew = False
				if(StoredVariable219 != null)
				{
					TaleNode StoredVariable220 = ((TaleNode)StoredVariable219.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
					if(StoredVariable220 != null)
					{
						System.Boolean ifResult221; //IsContext = False IsNew = False
						
						System.Boolean OperandVar224 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar222 = default(System.String); //IsContext = False IsNew = False
						OperandVar222 = "decomposed";
						System.Boolean prop223 = StoredVariable218.HasMarker( (OperandVar222)); //IsContext = False IsNew = False
						OperandVar224 = prop223;
						
						System.Boolean OperandVar226 = default(System.Boolean); //IsContext = False IsNew = False
						System.Boolean prop225 = StoredVariable220.IsActive; //IsContext = False IsNew = False
						OperandVar226 = prop225;
						if(ifResult221 = ( (!(OperandVar224))) && ( ( (OperandVar226))))
						{
							applicable = true;
							OperandVar227 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar227);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			{
				Markers subContext228 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext228 ContextSwitchInterpreter
				if(subContext228 != null)
				{
					System.String OperandVar229 = default(System.String); //IsContext = False IsNew = False
					OperandVar229 = "decomposed";
					subContext228.SetMarker(( (OperandVar229)).ToString());
				}
			}
			UnityEngine.GameObject c_node = new UnityEngine.GameObject("c_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject c_node230 = c_node; //IsContext = True IsNew = False
				Markers AddContext231 = (Markers)c_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext232 = (TaleNode)c_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.conflict_node AddContext233 = (Blackboards.conflict_node)c_node.AddComponent(typeof(Blackboards.conflict_node)); //IsContext = True IsNew = True
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(c_node);
			UnityEngine.GameObject c_r_node = new UnityEngine.GameObject("c_r_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject c_r_node234 = c_r_node; //IsContext = True IsNew = False
				Markers AddContext235 = (Markers)c_r_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext236 = (TaleNode)c_r_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.conflict_resolution_node AddContext237 = (Blackboards.conflict_resolution_node)c_r_node.AddComponent(typeof(Blackboards.conflict_resolution_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.conflict_resolution_node AddContext237 ContextSwitchInterpreter
					if(AddContext237 != null)
					{
						UnityEngine.GameObject OperandVar238 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar238 = c_node;
						AddContext237.Conflict = (UnityEngine.GameObject)( (OperandVar238));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(c_r_node);
			UnityEngine.GameObject r_node = new UnityEngine.GameObject("r_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject r_node239 = r_node; //IsContext = True IsNew = False
				Markers AddContext240 = (Markers)r_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext241 = (TaleNode)r_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.result_node AddContext242 = (Blackboards.result_node)r_node.AddComponent(typeof(Blackboards.result_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.result_node AddContext242 ContextSwitchInterpreter
					if(AddContext242 != null)
					{
						UnityEngine.GameObject OperandVar243 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar243 = c_r_node;
						AddContext242.Resolution = (UnityEngine.GameObject)( (OperandVar243));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(r_node);
			UnityEngine.GameObject s_node = new UnityEngine.GameObject("s_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject s_node244 = s_node; //IsContext = True IsNew = False
				Markers AddContext245 = (Markers)s_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext246 = (TaleNode)s_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.solution_node AddContext247 = (Blackboards.solution_node)s_node.AddComponent(typeof(Blackboards.solution_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.solution_node AddContext247 ContextSwitchInterpreter
					if(AddContext247 != null)
					{
						UnityEngine.GameObject OperandVar248 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar248 = c_r_node;
						AddContext247.Cause = (UnityEngine.GameObject)( (OperandVar248));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(s_node);
			UnityEngine.GameObject cris_node = new UnityEngine.GameObject("cris_node"); //IsContext = False IsNew = False
			
			{
				UnityEngine.GameObject cris_node249 = cris_node; //IsContext = True IsNew = False
				Markers AddContext250 = (Markers)cris_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				TaleNode AddContext251 = (TaleNode)cris_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
				Blackboards.crisis_node AddContext252 = (Blackboards.crisis_node)cris_node.AddComponent(typeof(Blackboards.crisis_node)); //IsContext = True IsNew = True
				
				{
					//ContextStatement Blackboards.crisis_node AddContext252 ContextSwitchInterpreter
					if(AddContext252 != null)
					{
						UnityEngine.GameObject OperandVar253 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar253 = s_node;
						AddContext252.Solution = (UnityEngine.GameObject)( (OperandVar253));
						UnityEngine.GameObject OperandVar254 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
						OperandVar254 = r_node;
						AddContext252.Cause = (UnityEngine.GameObject)( (OperandVar254));
					}
				}
			}
			UnityEngine.Object.FindObjectOfType<Generators>().Generate(cris_node);
			
			{
				UnityEngine.GameObject subContext255 = r_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext255 ContextPropertySwitchInterpreter
				if(subContext255 != null)
				{
					
					{
						TaleNode subContext256 = (TaleNode)subContext255.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext256 ContextSwitchInterpreter
						if(subContext256 != null)
						{
							
							subContext256.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
			
			{
				UnityEngine.GameObject subContext257 = c_node; //IsContext = True IsNew = False
				//ContextStatement UnityEngine.GameObject subContext257 ContextPropertySwitchInterpreter
				if(subContext257 != null)
				{
					
					{
						TaleNode subContext258 = (TaleNode)subContext257.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
						//ContextStatement TaleNode subContext258 ContextSwitchInterpreter
						if(subContext258 != null)
						{
							
							subContext258.IsActive = (System.Boolean)( (true));
						}
					}
				}
			}
		}
        }
    }
    
    public class conflict_basic_decomposition : EventAction {
        
        public override bool Filter() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Boolean applicable = false; //IsContext = False IsNew = False
			
			System.Boolean OperandVar268 = default(System.Boolean); //IsContext = False IsNew = False
			Markers StoredVariable259 = ((Markers)root.GetComponent(typeof(Markers))); //IsContext = False IsNew = False
			if(StoredVariable259 != null)
			{
				Blackboards.conflict_node StoredVariable260 = ((Blackboards.conflict_node)StoredVariable259.GetComponent(typeof(Blackboards.conflict_node))); //IsContext = False IsNew = False
				if(StoredVariable260 != null)
				{
					TaleNode StoredVariable261 = ((TaleNode)StoredVariable260.GetComponent(typeof(TaleNode))); //IsContext = False IsNew = False
					if(StoredVariable261 != null)
					{
						System.Boolean ifResult262; //IsContext = False IsNew = False
						
						System.Boolean OperandVar265 = default(System.Boolean); //IsContext = False IsNew = False
						System.String OperandVar263 = default(System.String); //IsContext = False IsNew = False
						OperandVar263 = "decomposed";
						System.Boolean prop264 = StoredVariable259.HasMarker( (OperandVar263)); //IsContext = False IsNew = False
						OperandVar265 = prop264;
						
						System.Boolean OperandVar267 = default(System.Boolean); //IsContext = False IsNew = False
						System.Boolean prop266 = StoredVariable261.IsActive; //IsContext = False IsNew = False
						OperandVar267 = prop266;
						if(ifResult262 = ( (!(OperandVar265))) && ( ( (OperandVar267))))
						{
							applicable = true;
							OperandVar268 = applicable;
						}
					}
				}
			}
			return (System.Boolean) (OperandVar268);
		}
        }
        
        public override float Utility() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			System.Single ut = 0; //IsContext = False IsNew = False
			
			
			return (System.Single) (1f);
		}
        }
        
        public override void Action() {

		{
			var root = this.root;
			
			//ContextStatement External External ContextSwitchInterpreter
			
			
			for (int i = 0; i <  (2f); i++)
			{
				UnityEngine.GameObject f_node = new UnityEngine.GameObject("f_node"); //IsContext = False IsNew = False
				
				{
					UnityEngine.GameObject f_node269 = f_node; //IsContext = True IsNew = False
					TaleNode AddContext270 = (TaleNode)f_node.AddComponent(typeof(TaleNode)); //IsContext = True IsNew = True
					Blackboards.faction_node AddContext271 = (Blackboards.faction_node)f_node.AddComponent(typeof(Blackboards.faction_node)); //IsContext = True IsNew = True
					
					{
						//ContextStatement Blackboards.faction_node AddContext271 ContextSwitchInterpreter
						if(AddContext271 != null)
						{
							UnityEngine.GameObject OperandVar272 = default(UnityEngine.GameObject); //IsContext = False IsNew = False
							OperandVar272 = root;
							AddContext271.Conflict = (UnityEngine.GameObject)( (OperandVar272));
						}
					}
					Markers AddContext273 = (Markers)f_node.AddComponent(typeof(Markers)); //IsContext = True IsNew = True
				}
				UnityEngine.Object.FindObjectOfType<Generators>().Generate(f_node);
				
				{
					UnityEngine.GameObject subContext274 = f_node; //IsContext = True IsNew = False
					//ContextStatement UnityEngine.GameObject subContext274 ContextPropertySwitchInterpreter
					if(subContext274 != null)
					{
						
						{
							TaleNode subContext275 = (TaleNode)subContext274.GetComponent(typeof(TaleNode)); //IsContext = True IsNew = False
							//ContextStatement TaleNode subContext275 ContextSwitchInterpreter
							if(subContext275 != null)
							{
								
								subContext275.IsActive = (System.Boolean)( (true));
							}
						}
					}
				}
			}
			
			{
				Markers subContext276 = (Markers)root.GetComponent(typeof(Markers)); //IsContext = True IsNew = False
				//ContextStatement Markers subContext276 ContextSwitchInterpreter
				if(subContext276 != null)
				{
					System.String OperandVar277 = default(System.String); //IsContext = False IsNew = False
					OperandVar277 = "decomposed";
					subContext276.SetMarker(( (OperandVar277)).ToString());
				}
			}
		}
        }
    }
}
